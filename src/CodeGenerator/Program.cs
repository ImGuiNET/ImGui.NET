using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGenerator
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string outputPath;
            if (args.Length > 0)
            {
                outputPath = args[0];
            }
            else
            {
                outputPath = AppContext.BaseDirectory;
            }

            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            string libraryName;
            if (args.Length > 1)
            {
                libraryName = args[1];
            }
            else
            {
                libraryName = "cimgui";
            }

            string projectNamespace = libraryName switch
            {
                "cimgui" => "ImGuiNET",
                "cimplot" => "ImPlotNET",
                "cimnodes" => "imnodesNET",
                "cimguizmo" => "ImGuizmoNET",
                _ => throw new NotImplementedException($"Library \"{libraryName}\" is not supported.")
            };

            bool referencesImGui = libraryName switch
            {
                "cimgui" => false,
                "cimplot" => true,
                "cimnodes" => true,
                "cimguizmo" => true,
                _ => throw new NotImplementedException($"Library \"{libraryName}\" is not supported.")
            };

            string classPrefix = libraryName switch
            {
                "cimgui" => "ImGui",
                "cimplot" => "ImPlot",
                "cimnodes" => "imnodes",
                "cimguizmo" => "ImGuizmo",
                _ => throw new NotImplementedException($"Library \"{libraryName}\" is not supported.")
            };

            string dllName = libraryName switch
            {
                "cimgui" => "cimgui",
                "cimplot" => "cimplot",
                "cimnodes" => "cimnodes",
                "cimguizmo" => "cimguizmo",
                _ => throw new NotImplementedException()
            };
            
            string definitionsPath = Path.Combine(AppContext.BaseDirectory, "definitions", libraryName);
            var defs = new ImguiDefinitions();
            defs.LoadFrom(definitionsPath);

            Console.WriteLine($"Outputting generated code files to {outputPath}.");

            foreach (EnumDefinition ed in defs.Enums)
            {
                using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, ed.FriendlyNames[0] + ".gen.cs")))
                {
                    writer.PushBlock($"namespace {projectNamespace}");
                    if (ed.FriendlyNames[0].Contains("Flags"))
                    {
                        writer.WriteLine("[System.Flags]");
                    }
                    writer.PushBlock($"public enum {ed.FriendlyNames[0]}");
                    foreach (EnumMember member in ed.Members)
                    {
                        string sanitizedName = ed.SanitizeNames(member.Name);
                        string sanitizedValue = ed.SanitizeNames(member.Value);
                        writer.WriteLine($"{sanitizedName} = {sanitizedValue},");
                    }
                    writer.PopBlock();
                    writer.PopBlock();
                }
            }

            foreach (TypeDefinition td in defs.Types)
            {
                if (TypeInfo.CustomDefinedTypes.Contains(td.Name)) { continue; }

                using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, td.Name + ".gen.cs")))
                {
                    writer.Using("System");
                    writer.Using("System.Numerics");
                    writer.Using("System.Runtime.CompilerServices");
                    writer.Using("System.Text");
                    if (referencesImGui)
                    {
                        writer.Using("ImGuiNET");
                    }
                    writer.WriteLine(string.Empty);
                    writer.PushBlock($"namespace {projectNamespace}");

                    writer.PushBlock($"public unsafe partial struct {td.Name}");
                    foreach (TypeReference field in td.Fields)
                    {
                        string typeStr = GetTypeString(field.Type, field.IsFunctionPointer);

                        if (field.ArraySize != 0)
                        {
                            if (TypeInfo.LegalFixedTypes.Contains(typeStr))
                            {
                                writer.WriteLine($"public fixed {typeStr} {field.Name}[{field.ArraySize}];");
                            }
                            else
                            {
                                for (int i = 0; i < field.ArraySize; i++)
                                {
                                    writer.WriteLine($"public {typeStr} {field.Name}_{i};");
                                }
                            }
                        }
                        else
                        {
                            writer.WriteLine($"public {typeStr} {field.Name};");
                        }
                    }
                    writer.PopBlock();

                    string ptrTypeName = td.Name + "Ptr";
                    writer.PushBlock($"public unsafe partial struct {ptrTypeName}");
                    writer.WriteLine($"public {td.Name}* NativePtr {{ get; }}");
                    writer.WriteLine($"public {ptrTypeName}({td.Name}* nativePtr) => NativePtr = nativePtr;");
                    writer.WriteLine($"public {ptrTypeName}(IntPtr nativePtr) => NativePtr = ({td.Name}*)nativePtr;");
                    writer.WriteLine($"public static implicit operator {ptrTypeName}({td.Name}* nativePtr) => new {ptrTypeName}(nativePtr);");
                    writer.WriteLine($"public static implicit operator {td.Name}* ({ptrTypeName} wrappedPtr) => wrappedPtr.NativePtr;");
                    writer.WriteLine($"public static implicit operator {ptrTypeName}(IntPtr nativePtr) => new {ptrTypeName}(nativePtr);");

                    foreach (TypeReference field in td.Fields)
                    {
                        string typeStr = GetTypeString(field.Type, field.IsFunctionPointer);
                        string rawType = typeStr;

                        if (TypeInfo.WellKnownFieldReplacements.TryGetValue(field.Type, out string wellKnownFieldType))
                        {
                            typeStr = wellKnownFieldType;
                        }

                        if (field.ArraySize != 0)
                        {
                            string addrTarget = TypeInfo.LegalFixedTypes.Contains(rawType) ? $"NativePtr->{field.Name}" : $"&NativePtr->{field.Name}_0";
                            writer.WriteLine($"public RangeAccessor<{typeStr}> {field.Name} => new RangeAccessor<{typeStr}>({addrTarget}, {field.ArraySize});");
                        }
                        else if (typeStr.Contains("ImVector"))
                        {
                            string vectorElementType = GetTypeString(field.TemplateType, false);

                            if (TypeInfo.WellKnownTypes.TryGetValue(vectorElementType, out string wellKnown))
                            {
                                vectorElementType = wellKnown;
                            }

                            if (GetWrappedType(vectorElementType + "*", out string wrappedElementType))
                            {
                                writer.WriteLine($"public ImPtrVector<{wrappedElementType}> {field.Name} => new ImPtrVector<{wrappedElementType}>(NativePtr->{field.Name}, Unsafe.SizeOf<{vectorElementType}>());");
                            }
                            else
                            {
                                if (GetWrappedType(vectorElementType, out wrappedElementType))
                                {
                                    vectorElementType = wrappedElementType;
                                }
                                writer.WriteLine($"public ImVector<{vectorElementType}> {field.Name} => new ImVector<{vectorElementType}>(NativePtr->{field.Name});");
                            }
                        }
                        else
                        {
                            if (typeStr.Contains("*") && !typeStr.Contains("ImVector"))
                            {
                                if (GetWrappedType(typeStr, out string wrappedTypeName))
                                {
                                    writer.WriteLine($"public {wrappedTypeName} {field.Name} => new {wrappedTypeName}(NativePtr->{field.Name});");
                                }
                                else if (typeStr == "byte*" && IsStringFieldName(field.Name))
                                {
                                    writer.WriteLine($"public NullTerminatedString {field.Name} => new NullTerminatedString(NativePtr->{field.Name});");
                                }
                                else
                                {
                                    writer.WriteLine($"public IntPtr {field.Name} {{ get => (IntPtr)NativePtr->{field.Name}; set => NativePtr->{field.Name} = ({typeStr})value; }}");
                                }
                            }
                            else
                            {
                                writer.WriteLine($"public ref {typeStr} {field.Name} => ref Unsafe.AsRef<{typeStr}>(&NativePtr->{field.Name});");
                            }
                        }
                    }

                    foreach (FunctionDefinition fd in defs.Functions)
                    {
                        foreach (OverloadDefinition overload in fd.Overloads)
                        {
                            if (overload.StructName != td.Name)
                            {
                                continue;
                            }

                            if (overload.IsConstructor)
                            {
                                // TODO: Emit a static function on the type that invokes the native constructor.
                                // Also, add a "Dispose" function or similar.
                                continue;
                            }

                            string exportedName = overload.ExportedName;
                            if (exportedName.StartsWith("ig"))
                            {
                                exportedName = exportedName.Substring(2, exportedName.Length - 2);
                            }
                            if (exportedName.Contains("~")) { continue; }
                            if (overload.Parameters.Any(tr => tr.Type.Contains('('))) { continue; } // TODO: Parse function pointer parameters.

                            bool hasVaList = false;
                            for (int i = 0; i < overload.Parameters.Length; i++)
                            {
                                TypeReference p = overload.Parameters[i];
                                string paramType = GetTypeString(p.Type, p.IsFunctionPointer);
                                if (p.Name == "...") { continue; }

                                if (paramType == "va_list")
                                {
                                    hasVaList = true;
                                    break;
                                }
                            }
                            if (hasVaList) { continue; }

                            KeyValuePair<string, string>[] orderedDefaults = overload.DefaultValues.OrderByDescending(
                                kvp => GetIndex(overload.Parameters, kvp.Key)).ToArray();

                            for (int i = overload.DefaultValues.Count; i >= 0; i--)
                            {
                                Dictionary<string, string> defaults = new Dictionary<string, string>();
                                for (int j = 0; j < i; j++)
                                {
                                    defaults.Add(orderedDefaults[j].Key, orderedDefaults[j].Value);
                                }
                                EmitOverload(writer, overload, defaults, "NativePtr", classPrefix);
                            }
                        }
                    }
                    writer.PopBlock();

                    writer.PopBlock();
                }
            }

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, $"{classPrefix}Native.gen.cs")))
            {
                writer.Using("System");
                writer.Using("System.Numerics");
                writer.Using("System.Runtime.InteropServices");
                if (referencesImGui)
                {
                    writer.Using("ImGuiNET");
                }
                writer.WriteLine(string.Empty);
                writer.PushBlock($"namespace {projectNamespace}");
                writer.PushBlock($"public static unsafe partial class {classPrefix}Native");
                foreach (FunctionDefinition fd in defs.Functions)
                {
                    foreach (OverloadDefinition overload in fd.Overloads)
                    {
                        string exportedName = overload.ExportedName;
                        if (exportedName.Contains("~")) { continue; }
                        if (exportedName.Contains("ImVector_")) { continue; }
                        if (exportedName.Contains("ImChunkStream_")) { continue; }

                        if (overload.Parameters.Any(tr => tr.Type.Contains('('))) { continue; } // TODO: Parse function pointer parameters.

                        string ret = GetTypeString(overload.ReturnType, false);

                        bool hasVaList = false;
                        List<string> paramParts = new List<string>();
                        for (int i = 0; i < overload.Parameters.Length; i++)
                        {
                            TypeReference p = overload.Parameters[i];
                            string paramType = GetTypeString(p.Type, p.IsFunctionPointer);
                            if (p.ArraySize != 0)
                            {
                                paramType = paramType + "*";
                            }

                            if (p.Name == "...") { continue; }

                            paramParts.Add($"{paramType} {CorrectIdentifier(p.Name)}");

                            if (paramType == "va_list")
                            {
                                hasVaList = true;
                                break;
                            }
                        }

                        if (hasVaList) { continue; }

                        string parameters = string.Join(", ", paramParts);

                        bool isUdtVariant = exportedName.Contains("nonUDT");
                        string methodName = isUdtVariant
                            ? exportedName.Substring(0, exportedName.IndexOf("_nonUDT"))
                            : exportedName;

                        if (isUdtVariant)
                        {
                            writer.WriteLine($"[DllImport(\"{dllName}\", CallingConvention = CallingConvention.Cdecl, EntryPoint = \"{exportedName}\")]");

                        }
                        else
                        {
                            writer.WriteLine($"[DllImport(\"{dllName}\", CallingConvention = CallingConvention.Cdecl)]");
                        }
                        writer.WriteLine($"public static extern {ret} {methodName}({parameters});");
                    }
                }
                writer.PopBlock();
                writer.PopBlock();
            }

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, $"{classPrefix}.gen.cs")))
            {
                writer.Using("System");
                writer.Using("System.Numerics");
                writer.Using("System.Runtime.InteropServices");
                writer.Using("System.Text");
                if (referencesImGui)
                {
                    writer.Using("ImGuiNET");
                }
                writer.WriteLine(string.Empty);
                writer.PushBlock($"namespace {projectNamespace}");
                writer.PushBlock($"public static unsafe partial class {classPrefix}");
                foreach (FunctionDefinition fd in defs.Functions)
                {
                    if (TypeInfo.SkippedFunctions.Contains(fd.Name)) { continue; }

                    foreach (OverloadDefinition overload in fd.Overloads)
                    {
                        string exportedName = overload.ExportedName;
                        if (exportedName.StartsWith("ig"))
                        {
                            exportedName = exportedName.Substring(2, exportedName.Length - 2);
                        }
                        if (exportedName.Contains("~")) { continue; }
                        if (overload.Parameters.Any(tr => tr.Type.Contains('('))) { continue; } // TODO: Parse function pointer parameters.
                        
                        if ((overload.FriendlyName == "GetID" || overload.FriendlyName == "PushID") && overload.Parameters.Length > 1)
                        {
                            // skip ImGui.Get/PushID(start, end) overloads as they would overlap with existing
                            continue;
                        }

                        bool hasVaList = false;
                        for (int i = 0; i < overload.Parameters.Length; i++)
                        {
                            TypeReference p = overload.Parameters[i];
                            string paramType = GetTypeString(p.Type, p.IsFunctionPointer);
                            if (p.Name == "...") { continue; }

                            if (paramType == "va_list")
                            {
                                hasVaList = true;
                                break;
                            }
                        }
                        if (hasVaList) { continue; }

                        KeyValuePair<string, string>[] orderedDefaults = overload.DefaultValues.OrderByDescending(
                            kvp => GetIndex(overload.Parameters, kvp.Key)).ToArray();

                        for (int i = overload.DefaultValues.Count; i >= 0; i--)
                        {
                            if (overload.IsMemberFunction) { continue; }
                            Dictionary<string, string> defaults = new Dictionary<string, string>();
                            for (int j = 0; j < i; j++)
                            {
                                defaults.Add(orderedDefaults[j].Key, orderedDefaults[j].Value);
                            }
                            EmitOverload(writer, overload, defaults, null, classPrefix);
                        }
                    }
                }
                writer.PopBlock();
                writer.PopBlock();
            }

            foreach (var method in defs.Variants)
            {
                foreach (var variant in method.Value.Parameters)
                {
                    if (!variant.Used) Console.WriteLine($"Error: Variants targetting parameter {variant.Name} with type {variant.OriginalType} could not be applied to method {method.Key}.");
                }
            }
        }

        private static bool IsStringFieldName(string name)
        {
            return Regex.IsMatch(name, ".*Filename.*")
                || Regex.IsMatch(name, ".*Name");
        }

        private static string GetImVectorElementType(string typeStr)
        {
            int start = typeStr.IndexOf('<') + 1;
            int end = typeStr.IndexOf('>');
            int length = end - start;
            return typeStr.Substring(start, length);
        }

        private static int GetIndex(TypeReference[] parameters, string key)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (key == parameters[i].Name) { return i; }
            }

            throw new InvalidOperationException();
        }

        private static void EmitOverload(
            CSharpCodeWriter writer,
            OverloadDefinition overload,
            Dictionary<string, string> defaultValues,
            string selfName,
            string classPrefix)
        {
            var rangeParams = overload.Parameters.Where(tr => 
                tr.Name.EndsWith("_begin") || 
                tr.Name.EndsWith("_end")).ToArray();
            if (rangeParams.Any(tr => tr.Type != "char*"))
            {
                // only string supported for start/end. ImFont.IsGlyphRangeUnused is uint
                return; 
            }
            if (rangeParams.Any(tr => tr.Name.EndsWith("_end") && defaultValues.ContainsKey(tr.Name)))
            {
                // we want overloads:
                // (something, text_start, text_end (deleted), after=default)
                // (something, text_start, text_end (deleted), after)
                
                // we dont need (as it would be duplicate)
                // (something, text_start, text_end=default (deleted))
                return;
            }

            Debug.Assert(!overload.IsMemberFunction || selfName != null);

            string nativeRet = GetTypeString(overload.ReturnType, false);
            bool isWrappedType = GetWrappedType(nativeRet, out string safeRet);
            if (!isWrappedType)
            {
                safeRet = GetSafeType(overload.ReturnType);
            }

            List<(string MarshalledType, string CorrectedIdentifier)> invocationArgs = new();
            MarshalledParameter[] marshalledParameters = new MarshalledParameter[overload.Parameters.Length];
            List<string> preCallLines = new List<string>();
            List<string> postCallLines = new List<string>();
            List<string> byRefParams = new List<string>();
            int selfIndex = -1;
            int pOutIndex = -1;
            string overrideRet = null;
            for (int i = 0; i < overload.Parameters.Length; i++)
            {
                TypeReference tr = overload.Parameters[i];
                if (tr.Name == "self")
                {
                    selfIndex = i;
                    continue; 
                }
                if (tr.Name == "...") { continue; }

                string correctedIdentifier = CorrectIdentifier(tr.Name);
                string nativeTypeName = GetTypeString(tr.Type, tr.IsFunctionPointer);
                if (correctedIdentifier == "pOut" && overload.ReturnType == "void")
                {
                    pOutIndex = i;
                    overrideRet = nativeTypeName.TrimEnd('*');
                    preCallLines.Add($"{overrideRet} __retval;");
                    continue;
                }
                if (tr.Type == "char*")
                {
                    string textToEncode = correctedIdentifier;
                    bool hasDefault = false;
                    if (defaultValues.TryGetValue(tr.Name, out string defaultStrVal))
                    {
                        hasDefault = true;
                        if (!CorrectDefaultValue(defaultStrVal, tr, out string correctedDefault))
                        {
                            correctedDefault = defaultStrVal;
                        }

                        textToEncode = correctedDefault;
                    }

                    string nativeArgName = "native_" + tr.Name;
                    marshalledParameters[i] = new MarshalledParameter("string", false, nativeArgName, hasDefault);

                    if (textToEncode == "null")
                    {
                        preCallLines.Add($"byte* {nativeArgName} = null;");
                    }
                    else
                    {
                        if (tr.Name.EndsWith("_end"))
                        {
                            var startParamName = overload.Parameters[i-1].Name;
                            var startNativeParamName = $"native_{startParamName}";
                            marshalledParameters[i] = new MarshalledParameter(nativeTypeName, false, $"{startNativeParamName}+{startParamName}_byteCount", false);
                            continue;
                        }
                        
                        var checkForNull = !hasDefault && !tr.Name.EndsWith("_begin");
                        // for string _begin the pointer passed must be non-null, so we'll set up an empty string if needed
                        
                        preCallLines.Add($"byte* {nativeArgName};");
                        preCallLines.Add($"int {correctedIdentifier}_byteCount = 0;");
                        if (checkForNull)
                        {
                            preCallLines.Add($"if ({textToEncode} != null)");
                            preCallLines.Add("{");
                        }
                        preCallLines.Add($"    {correctedIdentifier}_byteCount = Encoding.UTF8.GetByteCount({textToEncode});");
                        preCallLines.Add($"    if ({correctedIdentifier}_byteCount > Util.StackAllocationSizeLimit)");
                        preCallLines.Add($"    {{");
                        preCallLines.Add($"        {nativeArgName} = Util.Allocate({correctedIdentifier}_byteCount + 1);");
                        preCallLines.Add($"    }}");
                        preCallLines.Add($"    else");
                        preCallLines.Add($"    {{");
                        preCallLines.Add($"        byte* {nativeArgName}_stackBytes = stackalloc byte[{correctedIdentifier}_byteCount + 1];");
                        preCallLines.Add($"        {nativeArgName} = {nativeArgName}_stackBytes;");
                        preCallLines.Add($"    }}");
                        preCallLines.Add($"    int {nativeArgName}_offset = Util.GetUtf8({textToEncode}, {nativeArgName}, {correctedIdentifier}_byteCount);");
                        preCallLines.Add($"    {nativeArgName}[{nativeArgName}_offset] = 0;");

                        if (checkForNull)
                        {
                            preCallLines.Add("}");
                            preCallLines.Add($"else {{ {nativeArgName} = null; }}");
                        }

                        postCallLines.Add($"if ({correctedIdentifier}_byteCount > Util.StackAllocationSizeLimit)");
                        postCallLines.Add($"{{");
                        postCallLines.Add($"    Util.Free({nativeArgName});");
                        postCallLines.Add($"}}");
                    }
                }
                else if (defaultValues.TryGetValue(tr.Name, out string defaultVal))
                {
                    if (!CorrectDefaultValue(defaultVal, tr, out string correctedDefault))
                    {
                        correctedDefault = defaultVal;
                    }
                    marshalledParameters[i] = new MarshalledParameter(nativeTypeName, false, correctedIdentifier, true);
                    preCallLines.Add($"{nativeTypeName} {correctedIdentifier} = {correctedDefault};");
                }
                else if (tr.Type == "char* []")
                {
                    string nativeArgName = "native_" + tr.Name;
                    marshalledParameters[i] = new MarshalledParameter("string[]", false, nativeArgName, false);

                    preCallLines.Add($"int* {correctedIdentifier}_byteCounts = stackalloc int[{correctedIdentifier}.Length];");

                    preCallLines.Add($"int {correctedIdentifier}_byteCount = 0;");
                    preCallLines.Add($"for (int i = 0; i < {correctedIdentifier}.Length; i++)");
                    preCallLines.Add("{");
                    preCallLines.Add($"    string s = {correctedIdentifier}[i];");
                    preCallLines.Add($"    {correctedIdentifier}_byteCounts[i] = Encoding.UTF8.GetByteCount(s);");
                    preCallLines.Add($"    {correctedIdentifier}_byteCount += {correctedIdentifier}_byteCounts[i] + 1;");
                    preCallLines.Add("}");

                    preCallLines.Add($"byte* {nativeArgName}_data = stackalloc byte[{correctedIdentifier}_byteCount];");

                    preCallLines.Add("int offset = 0;");
                    preCallLines.Add($"for (int i = 0; i < {correctedIdentifier}.Length; i++)");
                    preCallLines.Add("{");
                    preCallLines.Add($"    string s = {correctedIdentifier}[i];");
                    preCallLines.Add($"    offset += Util.GetUtf8(s, {nativeArgName}_data + offset, {correctedIdentifier}_byteCounts[i]);");
                    preCallLines.Add($"    {nativeArgName}_data[offset++] = 0;");
                    preCallLines.Add("}");

                    preCallLines.Add($"byte** {nativeArgName} = stackalloc byte*[{correctedIdentifier}.Length];");
                    preCallLines.Add("offset = 0;");
                    preCallLines.Add($"for (int i = 0; i < {correctedIdentifier}.Length; i++)");
                    preCallLines.Add("{");
                    preCallLines.Add($"    {nativeArgName}[i] = &{nativeArgName}_data[offset];");
                    preCallLines.Add($"    offset += {correctedIdentifier}_byteCounts[i] + 1;");
                    preCallLines.Add("}");
                }
                else if (tr.Type == "bool")
                {
                    string nativeArgName = "native_" + tr.Name;
                    marshalledParameters[i] = new MarshalledParameter("bool", false, nativeArgName, false);
                    preCallLines.Add($"byte {nativeArgName} = {tr.Name} ? (byte)1 : (byte)0;");
                }
                else if (tr.Type == "bool*")
                {
                    string nativeArgName = "native_" + tr.Name;
                    marshalledParameters[i] = new MarshalledParameter("ref bool", false, nativeArgName, false);
                    preCallLines.Add($"byte {nativeArgName}_val = {correctedIdentifier} ? (byte)1 : (byte)0;");
                    preCallLines.Add($"byte* {nativeArgName} = &{nativeArgName}_val;");
                    postCallLines.Add($"{correctedIdentifier} = {nativeArgName}_val != 0;");
                }
                else if (tr.Type == "void*" || tr.Type == "ImWchar*")
                {
                    string nativePtrTypeName = tr.Type == "void*" ? "void*" : "ushort*";
                    string nativeArgName = "native_" + tr.Name;
                    marshalledParameters[i] = new MarshalledParameter("IntPtr", false, nativeArgName, false);
                    preCallLines.Add($"{nativePtrTypeName} {nativeArgName} = ({nativePtrTypeName}){correctedIdentifier}.ToPointer();");
                }
                else if (GetWrappedType(tr.Type, out string wrappedParamType)
                    && !TypeInfo.WellKnownTypes.ContainsKey(tr.Type)
                    && !TypeInfo.WellKnownTypes.ContainsKey(tr.Type.Substring(0, tr.Type.Length - 1)))
                {
                    marshalledParameters[i] = new MarshalledParameter(wrappedParamType, false, "native_" + tr.Name, false);
                    string nativeArgName = "native_" + tr.Name;
                    marshalledParameters[i] = new MarshalledParameter(wrappedParamType, false, nativeArgName, false);
                    preCallLines.Add($"{tr.Type} {nativeArgName} = {correctedIdentifier}.NativePtr;");
                }
                else if ((tr.Type.EndsWith("*") || tr.Type.Contains("[") || tr.Type.EndsWith("&")) && tr.Type != "void*" && tr.Type != "ImGuiContext*" && tr.Type != "ImPlotContext*"&& tr.Type != "EditorContext*")
                {
                    string nonPtrType;
                    if (tr.Type.Contains("["))
                    {
                        string wellKnown = TypeInfo.WellKnownTypes[tr.Type];
                        nonPtrType = GetTypeString(wellKnown.Substring(0, wellKnown.Length - 1), false);
                    }
                    else
                    {
                        nonPtrType = GetTypeString(tr.Type.Substring(0, tr.Type.Length - 1), false);
                    }
                    string nativeArgName = "native_" + tr.Name;
                    bool isOutParam = tr.Name.Contains("out_") || tr.Name == "out";
                    string direction = isOutParam ? "out" : "ref";
                    marshalledParameters[i] = new MarshalledParameter($"{direction} {nonPtrType}", true, nativeArgName, false);
                    marshalledParameters[i].PinTarget = CorrectIdentifier(tr.Name);
                }
                else
                {
                    marshalledParameters[i] = new MarshalledParameter(nativeTypeName, false, correctedIdentifier, false);
                }

                if (!marshalledParameters[i].HasDefaultValue)
                {
                    invocationArgs.Add((marshalledParameters[i].MarshalledType, correctedIdentifier));
                }
            }

            string invocationList = string.Join(", ", invocationArgs.Select(a => $"{a.MarshalledType} {a.CorrectedIdentifier}"));
            string friendlyName = overload.FriendlyName;

            string staticPortion = selfName == null ? "static " : string.Empty;
            
            // When .NET Standard 2.1 is available, we can use ReadOnlySpan<char> instead of string, so generate additional overloads for methods containing string parameters.
            if (invocationArgs.Count > 0 && invocationArgs.Any(a => a is { MarshalledType: "string" }))
            {
                string readOnlySpanInvocationList = string.Join(", ", invocationArgs.Select(a => $"{(a.MarshalledType == "string" ? "ReadOnlySpan<char>" : a.MarshalledType)} {a.CorrectedIdentifier}"));

                writer.WriteRaw("#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER");
                WriteMethod(writer, overload, selfName, classPrefix, staticPortion, overrideRet, safeRet, friendlyName, readOnlySpanInvocationList, preCallLines, marshalledParameters, selfIndex, pOutIndex, nativeRet, postCallLines, isWrappedType);
                writer.WriteRaw("#endif");
            }

            WriteMethod(writer, overload, selfName, classPrefix, staticPortion, overrideRet, safeRet, friendlyName, invocationList, preCallLines, marshalledParameters, selfIndex, pOutIndex, nativeRet, postCallLines, isWrappedType);
        }

        private static void WriteMethod(
            CSharpCodeWriter writer,
            OverloadDefinition overload,
            string selfName,
            string classPrefix,
            string staticPortion,
            string overrideRet,
            string safeRet,
            string friendlyName,
            string invocationList,
            List<string> preCallLines,
            MarshalledParameter[] marshalledParameters,
            int selfIndex,
            int pOutIndex,
            string nativeRet,
            List<string> postCallLines,
            bool isWrappedType)
        {
            writer.PushBlock($"public {staticPortion}{overrideRet ?? safeRet} {friendlyName}({invocationList})");

            foreach (string line in preCallLines)
            {
                writer.WriteLine(line);
            }

            List<string> nativeInvocationArgs = new();

            for (int i = 0; i < marshalledParameters.Length; i++)
            {
                TypeReference tr = overload.Parameters[i];
                if (selfIndex == i)
                {
                    //Some overloads seem to be generated with IntPtr as self
                    //instead of the proper pointer type. TODO: investigate
                    string tstr = GetTypeString(tr.Type, false);
                    nativeInvocationArgs.Add($"({tstr})({selfName})");
                    continue;
                }
                if (pOutIndex == i)
                {
                    nativeInvocationArgs.Add("&__retval");
                    continue;
                }
                MarshalledParameter mp = marshalledParameters[i];
                if (mp == null) { continue; }
                if (mp.IsPinned)
                {
                    string nativePinType = GetTypeString(tr.Type, false);
                    writer.PushBlock($"fixed ({nativePinType} native_{tr.Name} = &{mp.PinTarget})");
                }

                nativeInvocationArgs.Add(mp.VarName);
            }

            string nativeInvocationStr = string.Join(", ", nativeInvocationArgs);
            string ret = safeRet == "void" ? string.Empty : $"{nativeRet} ret = ";

            string targetName = overload.ExportedName;
            if (targetName.Contains("nonUDT"))
            {
                targetName = targetName.Substring(0, targetName.IndexOf("_nonUDT"));
            }

            writer.WriteLine($"{ret}{classPrefix}Native.{targetName}({nativeInvocationStr});");

            foreach (string line in postCallLines)
            {
                writer.WriteLine(line);
            }

            if (safeRet != "void")
            {
                if (safeRet == "bool")
                {
                    writer.WriteLine("return ret != 0;");
                }
                else if (overload.ReturnType == "char*")
                {
                    writer.WriteLine("return Util.StringFromPtr(ret);");
                }
                else if (overload.ReturnType == "ImWchar*")
                {
                    writer.WriteLine("return (IntPtr)ret;");
                }
                else if (overload.ReturnType == "void*")
                {
                    writer.WriteLine("return (IntPtr)ret;");
                }
                else
                {
                    string retVal = isWrappedType ? $"new {safeRet}(ret)" : "ret";
                    writer.WriteLine($"return {retVal};");
                }
            }

            if (overrideRet != null)
                writer.WriteLine("return __retval;");

            for (int i = 0; i < marshalledParameters.Length; i++)
            {
                MarshalledParameter mp = marshalledParameters[i];
                if (mp == null) { continue; }
                if (mp.IsPinned)
                {
                    writer.PopBlock();
                }
            }

            writer.PopBlock();
        }

        private static string GetSafeType(string nativeRet)
        {
            if (nativeRet == "bool")
            {
                return "bool";
            }
            else if (nativeRet == "char*")
            {
                return "string";
            }
            else if (nativeRet == "ImWchar*" || nativeRet == "void*")
            {
                return "IntPtr";
            }

            return GetTypeString(nativeRet, false);
        }

        private static string GetSafeType(TypeReference typeRef)
        {
            return typeRef.Type;
        }

        private static bool GetWrappedType(string nativeType, out string wrappedType)
        {
            if (nativeType.StartsWith("Im") && nativeType.EndsWith("*") && !nativeType.StartsWith("ImVector"))
            {
                int pointerLevel = nativeType.Length - nativeType.IndexOf('*');
                if (pointerLevel > 1)
                {
                    wrappedType = null;
                    return false; // TODO
                }
                string nonPtrType = nativeType.Substring(0, nativeType.Length - pointerLevel);

                if (TypeInfo.WellKnownTypes.ContainsKey(nonPtrType))
                {
                    wrappedType = null;
                    return false;
                }

                wrappedType = nonPtrType + "Ptr";

                return true;
            }
            else
            {
                wrappedType = null;
                return false;
            }
        }

        private static bool CorrectDefaultValue(string defaultVal, TypeReference tr, out string correctedDefault)
        {
            if (tr.Type == "ImGuiContext*" || tr.Type == "ImPlotContext*" || tr.Type == "EditorContext*")
            {
                correctedDefault = "IntPtr.Zero";
                return true;
            }

            if (TypeInfo.WellKnownDefaultValues.TryGetValue(defaultVal, out correctedDefault)) { return true; }

            if (tr.Type == "bool")
            {
                correctedDefault = bool.Parse(defaultVal) ? "1" : "0";
                return true;
            }

            if (defaultVal.Contains("%")) { correctedDefault = null; return false; }

            if (tr.IsEnum)
            {
                if (defaultVal.StartsWith("-"))
                {
                    correctedDefault = $"({tr.Type})({defaultVal})";
                }
                else
                {
                    correctedDefault = $"({tr.Type}){defaultVal}";
                }
                return true;
            }

            correctedDefault = defaultVal;
            return true;
        }

        private static string GetTypeString(string typeName, bool isFunctionPointer)
        {
            int pointerLevel = 0;
            if (typeName.EndsWith("**")) { pointerLevel = 2; }
            else if (typeName.EndsWith("*")) { pointerLevel = 1; }

            if (!TypeInfo.WellKnownTypes.TryGetValue(typeName, out string typeStr))
            {
                if (TypeInfo.WellKnownTypes.TryGetValue(typeName.Substring(0, typeName.Length - pointerLevel), out typeStr))
                {
                    typeStr = typeStr + new string('*', pointerLevel);
                }
                else if (!TypeInfo.WellKnownTypes.TryGetValue(typeName, out typeStr))
                {
                    typeStr = typeName;
                    if (isFunctionPointer) { typeStr = "IntPtr"; }
                }
            }

            return typeStr;
        }

        private static string CorrectIdentifier(string identifier)
        {
            if (TypeInfo.IdentifierReplacements.TryGetValue(identifier, out string replacement))
            {
                return replacement;
            }
            else
            {
                return identifier;
            }
        }
    }

    class MarshalledParameter
    {
        public MarshalledParameter(string marshalledType, bool isPinned, string varName, bool hasDefaultValue)
        {
            MarshalledType = marshalledType;
            IsPinned = isPinned;
            VarName = varName;
            HasDefaultValue = hasDefaultValue;
        }

        public string MarshalledType { get; }
        public bool IsPinned { get; }
        public string VarName { get; }
        public bool HasDefaultValue { get; }
        public string PinTarget { get; internal set; }
    }
}
