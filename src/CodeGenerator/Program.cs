using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeGenerator
{
    internal static class Program
    {
        private static readonly Dictionary<string, string> s_wellKnownTypes = new Dictionary<string, string>()
        {
            { "bool", "byte" },
            { "unsigned char", "byte" },
            { "char", "byte" },
            { "ImWchar", "ushort" },
            { "unsigned short", "ushort" },
            { "unsigned int", "uint" },
            { "ImVec2", "Vector2" },
            { "ImVec2_Simple", "Vector2" },
            { "ImVec3", "Vector3" },
            { "ImVec4", "Vector4" },
            { "ImVec4_Simple", "Vector4" },
            { "ImColor_Simple", "ImColor" },
            { "ImTextureID", "IntPtr" },
            { "ImGuiID", "uint" },
            { "ImDrawIdx", "ushort" },
            { "ImDrawListSharedData", "IntPtr" },
            { "ImDrawListSharedData*", "IntPtr" },
            { "ImU32", "uint" },
            { "ImDrawCallback", "IntPtr" },
            { "size_t", "uint" },
            { "ImGuiContext*", "IntPtr" },
            { "float[2]", "Vector2*" },
            { "float[3]", "Vector3*" },
            { "float[4]", "Vector4*" },
            { "int[2]", "int*" },
            { "int[3]", "int*" },
            { "int[4]", "int*" },
            { "float&", "float*" },
            { "ImVec2[2]", "Vector2*" },
            { "char* []", "byte**" },
        };

        private static readonly Dictionary<string, string> s_wellKnownFieldReplacements = new Dictionary<string, string>()
        {
            { "bool", "bool" }, // Force bool to remain as bool in type-safe wrappers.
        };

        private static readonly HashSet<string> s_customDefinedTypes = new HashSet<string>()
        {
            "ImVector",
            "ImVec2",
            "ImVec4",
            "ImGuiStoragePair",
        };

        private static readonly Dictionary<string, string> s_wellKnownDefaultValues = new Dictionary<string, string>()
        {
            { "((void *)0)", "null" },
            { "((void*)0)", "null" },
            { "ImVec2(0,0)", "new Vector2()" },
            { "ImVec2(-1,0)", "new Vector2(-1, 0)" },
            { "ImVec2(1,0)", "new Vector2(1, 0)" },
            { "ImVec2(1,1)", "new Vector2(1, 1)" },
            { "ImVec2(0,1)", "new Vector2(0, 1)" },
            { "ImVec4(0,0,0,0)", "new Vector4()" },
            { "ImVec4(1,1,1,1)", "new Vector4(1, 1, 1, 1)" },
            { "ImDrawCornerFlags_All", "ImDrawCornerFlags.All" },
            { "FLT_MAX", "float.MaxValue" },
            { "(((ImU32)(255)<<24)|((ImU32)(255)<<16)|((ImU32)(255)<<8)|((ImU32)(255)<<0))", "0xFFFFFFFF" }
        };

        private static readonly Dictionary<string, string> s_identifierReplacements = new Dictionary<string, string>()
        {
            { "in", "@in" },
            { "out", "@out" },
            { "ref", "@ref" },
        };

        private static readonly HashSet<string> s_legalFixedTypes = new HashSet<string>()
        {
            "byte",
            "sbyte",
            "char",
            "ushort",
            "short",
            "uint",
            "int",
            "ulong",
            "long",
            "float",
            "double",
        };

        private static readonly HashSet<string> s_skippedFunctions = new HashSet<string>()
        {
            "igInputText",
            "igInputTextMultiline"
        };

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
            Console.WriteLine($"Outputting generated code files to {outputPath}.");

            JObject typesJson;
            using (StreamReader fs = File.OpenText(Path.Combine(AppContext.BaseDirectory, "structs_and_enums.json")))
            using (JsonTextReader jr = new JsonTextReader(fs))
            {
                typesJson = JObject.Load(jr);
            }

            JObject functionsJson;
            using (StreamReader fs = File.OpenText(Path.Combine(AppContext.BaseDirectory, "definitions.json")))
            using (JsonTextReader jr = new JsonTextReader(fs))
            {
                functionsJson = JObject.Load(jr);
            }

            JObject variantsJson = null;
            if (File.Exists(Path.Combine(AppContext.BaseDirectory, "variants.json")))
            {
                using (StreamReader fs = File.OpenText(Path.Combine(AppContext.BaseDirectory, "variants.json")))
                using (JsonTextReader jr = new JsonTextReader(fs))
                {
                    variantsJson = JObject.Load(jr);
                }
            }

            Dictionary<string, MethodVariant> variants = new Dictionary<string, MethodVariant>();
            foreach (var jt in variantsJson.Children())
            {
                JProperty jp = (JProperty)jt;
                ParameterVariant[] methodVariants = jp.Values().Select(jv =>
                {
                    return new ParameterVariant(jv["name"].ToString(), jv["type"].ToString(), jv["variants"].Select(s => s.ToString()).ToArray());
                }).ToArray();
                variants.Add(jp.Name, new MethodVariant(jp.Name, methodVariants));
            }

            EnumDefinition[] enums = typesJson["enums"].Select(jt =>
            {
                JProperty jp = (JProperty)jt;
                string name = jp.Name;
                EnumMember[] elements = jp.Values().Select(v =>
                {
                    return new EnumMember(v["name"].ToString(), v["value"].ToString());
                }).ToArray();
                return new EnumDefinition(name, elements);
            }).ToArray();

            TypeDefinition[] types = typesJson["structs"].Select(jt =>
            {
                JProperty jp = (JProperty)jt;
                string name = jp.Name;
                TypeReference[] fields = jp.Values().Select(v =>
                {
                    if (v["type"].ToString().Contains("static")) { return null; }

                    return new TypeReference(
                        v["name"].ToString(),
                        v["type"].ToString(),
                        v["template_type"]?.ToString(),
                        enums);
                }).Where(tr => tr != null).ToArray();
                return new TypeDefinition(name, fields);
            }).ToArray();

            FunctionDefinition[] functions = functionsJson.Children().Select(jt =>
            {
                JProperty jp = (JProperty)jt;
                string name = jp.Name;
                bool hasNonUdtVariants = jp.Values().Any(val => val["ov_cimguiname"]?.ToString().EndsWith("nonUDT") ?? false);

                OverloadDefinition[] overloads = jp.Values().Select(val =>
                {
                    string ov_cimguiname = val["ov_cimguiname"]?.ToString();
                    string cimguiname = val["cimguiname"].ToString();
                    string friendlyName = val["funcname"]?.ToString();
                    if (cimguiname.EndsWith("_destroy"))
                    {
                        friendlyName = "Destroy";
                    }
                    if (friendlyName == null) { return null; }

                    string exportedName = ov_cimguiname;
                    if (exportedName == null)
                    {
                        exportedName = cimguiname;
                    }

                    if (hasNonUdtVariants && !exportedName.EndsWith("nonUDT2"))
                    {
                        return null;
                    }

                    string selfTypeName = null;
                    int underscoreIndex = exportedName.IndexOf('_');
                    if (underscoreIndex > 0 && !exportedName.StartsWith("ig")) // Hack to exclude some weirdly-named non-instance functions.
                    {
                        selfTypeName = exportedName.Substring(0, underscoreIndex);
                    }

                    List<TypeReference> parameters = new List<TypeReference>();

                    // find any variants that can be applied to the parameters of this method based on the method name
                    MethodVariant methodVariants = null;
                    variants.TryGetValue(jp.Name, out methodVariants);

                    foreach (JToken p in val["argsT"])
                    {
                        string pType = p["type"].ToString();
                        string pName = p["name"].ToString();

                        // if there are possible variants for this method then try to match them based on the parameter name and expected type
                        ParameterVariant matchingVariant = methodVariants?.Parameters.Where(pv => pv.Name == pName && pv.OriginalType == pType).FirstOrDefault() ?? null;
                        if (matchingVariant != null) matchingVariant.Used = true;

                        parameters.Add(new TypeReference(pName, pType, enums, matchingVariant?.VariantTypes));
                    }

                    Dictionary<string, string> defaultValues = new Dictionary<string, string>();
                    foreach (JToken dv in val["defaults"])
                    {
                        JProperty dvProp = (JProperty)dv;
                        defaultValues.Add(dvProp.Name, dvProp.Value.ToString());
                    }
                    string returnType = val["ret"]?.ToString() ?? "void";
                    string comment = null;

                    string structName = val["stname"].ToString();
                    bool isConstructor = val.Value<bool>("constructor");
                    bool isDestructor = val.Value<bool>("destructor");
                    if (isConstructor)
                    {
                        returnType = structName + "*";
                    }

                    return new OverloadDefinition(
                        exportedName,
                        friendlyName,
                        parameters.ToArray(),
                        defaultValues,
                        returnType,
                        structName,
                        comment,
                        isConstructor,
                        isDestructor);
                }).Where(od => od != null).ToArray();

                return new FunctionDefinition(name, overloads, enums);
            }).OrderBy(fd => fd.Name).ToArray();

            foreach (EnumDefinition ed in enums)
            {
                using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, ed.FriendlyName + ".gen.cs")))
                {
                    writer.PushBlock("namespace ImGuiNET");
                    if (ed.FriendlyName.Contains("Flags"))
                    {
                        writer.WriteLine("[System.Flags]");
                    }
                    writer.PushBlock($"public enum {ed.FriendlyName}");
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

            foreach (TypeDefinition td in types)
            {
                if (s_customDefinedTypes.Contains(td.Name)) { continue; }

                using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, td.Name + ".gen.cs")))
                {
                    writer.Using("System");
                    writer.Using("System.Numerics");
                    writer.Using("System.Runtime.CompilerServices");
                    writer.Using("System.Text");
                    writer.WriteLine(string.Empty);
                    writer.PushBlock("namespace ImGuiNET");

                    writer.PushBlock($"public unsafe partial struct {td.Name}");
                    foreach (TypeReference field in td.Fields)
                    {
                        string typeStr = GetTypeString(field.Type, field.IsFunctionPointer);

                        if (field.ArraySize != 0)
                        {
                            if (s_legalFixedTypes.Contains(typeStr))
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

                        if (s_wellKnownFieldReplacements.TryGetValue(field.Type, out string wellKnownFieldType))
                        {
                            typeStr = wellKnownFieldType;
                        }

                        if (field.ArraySize != 0)
                        {
                            string addrTarget = s_legalFixedTypes.Contains(rawType) ? $"NativePtr->{field.Name}" : $"&NativePtr->{field.Name}_0";
                            writer.WriteLine($"public RangeAccessor<{typeStr}> {field.Name} => new RangeAccessor<{typeStr}>({addrTarget}, {field.ArraySize});");
                        }
                        else if (typeStr.Contains("ImVector"))
                        {
                            string vectorElementType = GetTypeString(field.TemplateType, false);

                            if (s_wellKnownTypes.TryGetValue(vectorElementType, out string wellKnown))
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

                    foreach (FunctionDefinition fd in functions)
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
                                EmitOverload(writer, overload, defaults, "NativePtr");
                            }
                        }
                    }
                    writer.PopBlock();

                    writer.PopBlock();
                }
            }

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "ImGuiNative.gen.cs")))
            {
                writer.Using("System");
                writer.Using("System.Numerics");
                writer.Using("System.Runtime.InteropServices");
                writer.WriteLine(string.Empty);
                writer.PushBlock("namespace ImGuiNET");
                writer.PushBlock("public static unsafe partial class ImGuiNative");
                foreach (FunctionDefinition fd in functions)
                {
                    foreach (OverloadDefinition overload in fd.Overloads)
                    {
                        string exportedName = overload.ExportedName;
                        if (exportedName.Contains("~")) { continue; }
                        if (exportedName.Contains("ImVector_")) { continue; }
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
                            writer.WriteLine($"[DllImport(\"cimgui\", CallingConvention = CallingConvention.Cdecl, EntryPoint = \"{exportedName}\")]");

                        }
                        else
                        {
                            writer.WriteLine("[DllImport(\"cimgui\", CallingConvention = CallingConvention.Cdecl)]");
                        }
                        writer.WriteLine($"public static extern {ret} {methodName}({parameters});");
                    }
                }
                writer.PopBlock();
                writer.PopBlock();
            }

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "ImGui.gen.cs")))
            {
                writer.Using("System");
                writer.Using("System.Numerics");
                writer.Using("System.Runtime.InteropServices");
                writer.Using("System.Text");
                writer.WriteLine(string.Empty);
                writer.PushBlock("namespace ImGuiNET");
                writer.PushBlock("public static unsafe partial class ImGui");
                foreach (FunctionDefinition fd in functions)
                {
                    if (s_skippedFunctions.Contains(fd.Name)) { continue; }

                    foreach (OverloadDefinition overload in fd.Overloads)
                    {
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
                            if (overload.IsMemberFunction) { continue; }
                            Dictionary<string, string> defaults = new Dictionary<string, string>();
                            for (int j = 0; j < i; j++)
                            {
                                defaults.Add(orderedDefaults[j].Key, orderedDefaults[j].Value);
                            }
                            EmitOverload(writer, overload, defaults, null);
                        }
                    }
                }
                writer.PopBlock();
                writer.PopBlock();
            }

            foreach (var method in variants)
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
            string selfName)
        {
            if (overload.Parameters.Where(tr => tr.Name.EndsWith("_begin") || tr.Name.EndsWith("_end"))
                .Any(tr => !defaultValues.ContainsKey(tr.Name)))
            {
                return;
            }

            Debug.Assert(!overload.IsMemberFunction || selfName != null);

            string nativeRet = GetTypeString(overload.ReturnType, false);
            bool isWrappedType = GetWrappedType(nativeRet, out string safeRet);
            if (!isWrappedType)
            {
                safeRet = GetSafeType(overload.ReturnType);
            }

            List<string> invocationArgs = new List<string>();
            MarshalledParameter[] marshalledParameters = new MarshalledParameter[overload.Parameters.Length];
            List<string> preCallLines = new List<string>();
            List<string> postCallLines = new List<string>();
            List<string> byRefParams = new List<string>();

            for (int i = 0; i < overload.Parameters.Length; i++)
            {
                if (i == 0 && selfName != null) { continue; }

                TypeReference tr = overload.Parameters[i];
                if (tr.Name == "...") { continue; }

                string correctedIdentifier = CorrectIdentifier(tr.Name);
                string nativeTypeName = GetTypeString(tr.Type, tr.IsFunctionPointer);

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
                        preCallLines.Add($"byte* {nativeArgName};");
                        preCallLines.Add($"int {correctedIdentifier}_byteCount = 0;");
                        if (!hasDefault)
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

                        if (!hasDefault)
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
                    preCallLines.Add($"    fixed (char* sPtr = s)");
                    preCallLines.Add("    {");
                    preCallLines.Add($"        offset += Encoding.UTF8.GetBytes(sPtr, s.Length, {nativeArgName}_data + offset, {correctedIdentifier}_byteCounts[i]);");
                    preCallLines.Add($"        {nativeArgName}_data[offset] = 0;");
                    preCallLines.Add($"        offset += 1;");
                    preCallLines.Add("    }");
                    preCallLines.Add("}");

                    preCallLines.Add($"byte** {nativeArgName} = stackalloc byte*[{correctedIdentifier}.Length];");
                    preCallLines.Add("offset = 0;");
                    preCallLines.Add($"for (int i = 0; i < {correctedIdentifier}.Length; i++)");
                    preCallLines.Add("{");
                    preCallLines.Add($"    {nativeArgName}[i] = &{nativeArgName}_data[offset];");
                    preCallLines.Add($"    offset += {correctedIdentifier}_byteCounts[i] + 1;");
                    preCallLines.Add("}");
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
                    && !s_wellKnownTypes.ContainsKey(tr.Type)
                    && !s_wellKnownTypes.ContainsKey(tr.Type.Substring(0, tr.Type.Length - 1)))
                {
                    marshalledParameters[i] = new MarshalledParameter(wrappedParamType, false, "native_" + tr.Name, false);
                    string nativeArgName = "native_" + tr.Name;
                    marshalledParameters[i] = new MarshalledParameter(wrappedParamType, false, nativeArgName, false);
                    preCallLines.Add($"{tr.Type} {nativeArgName} = {correctedIdentifier}.NativePtr;");
                }
                else if ((tr.Type.EndsWith("*") || tr.Type.Contains("[") || tr.Type.EndsWith("&")) && tr.Type != "void*" && tr.Type != "ImGuiContext*")
                {
                    string nonPtrType;
                    if (tr.Type.Contains("["))
                    {
                        string wellKnown = s_wellKnownTypes[tr.Type];
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
                    invocationArgs.Add($"{marshalledParameters[i].MarshalledType} {correctedIdentifier}");
                }
            }

            string invocationList = string.Join(", ", invocationArgs);
            string friendlyName = overload.FriendlyName;

            string staticPortion = selfName == null ? "static " : string.Empty;
            writer.PushBlock($"public {staticPortion}{safeRet} {friendlyName}({invocationList})");
            foreach (string line in preCallLines)
            {
                writer.WriteLine(line);
            }

            List<string> nativeInvocationArgs = new List<string>();

            if (selfName != null)
            {
                nativeInvocationArgs.Add(selfName);
            }

            for (int i = 0; i < marshalledParameters.Length; i++)
            {
                TypeReference tr = overload.Parameters[i];
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

            writer.WriteLine($"{ret}ImGuiNative.{targetName}({nativeInvocationStr});");

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

                if (s_wellKnownTypes.ContainsKey(nonPtrType))
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
            if (tr.Type == "ImGuiContext*")
            {
                correctedDefault = "IntPtr.Zero";
                return true;
            }

            if (s_wellKnownDefaultValues.TryGetValue(defaultVal, out correctedDefault)) { return true; }

            if (tr.Type == "bool")
            {
                correctedDefault = bool.Parse(defaultVal) ? "1" : "0";
                return true;
            }

            if (defaultVal.Contains("%")) { correctedDefault = null; return false; }

            if (tr.IsEnum)
            {
                correctedDefault = $"({tr.Type}){defaultVal}";
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

            if (!s_wellKnownTypes.TryGetValue(typeName, out string typeStr))
            {
                if (s_wellKnownTypes.TryGetValue(typeName.Substring(0, typeName.Length - pointerLevel), out typeStr))
                {
                    typeStr = typeStr + new string('*', pointerLevel);
                }
                else if (!s_wellKnownTypes.TryGetValue(typeName, out typeStr))
                {
                    typeStr = typeName;
                    if (isFunctionPointer) { typeStr = "IntPtr"; }
                }
            }

            return typeStr;
        }

        private static string CorrectIdentifier(string identifier)
        {
            if (s_identifierReplacements.TryGetValue(identifier, out string replacement))
            {
                return replacement;
            }
            else
            {
                return identifier;
            }
        }
    }

    class MethodVariant
    {
        public string Name { get; }

        public ParameterVariant[] Parameters { get; }

        public MethodVariant(string name, ParameterVariant[] parameters)
        {
            Name = name;
            Parameters = parameters;
        }
    }

    class ParameterVariant
    {
        public string Name { get; }

        public string OriginalType { get; }

        public string[] VariantTypes { get; }

        public bool Used { get; set; }

        public ParameterVariant(string name, string originalType, string[] variantTypes)
        {
            Name = name;
            OriginalType = originalType;
            VariantTypes = variantTypes;
            Used = false;
        }
    }

    class EnumDefinition
    {
        private readonly Dictionary<string, string> _sanitizedNames;

        public string Name { get; }
        public string FriendlyName { get; }
        public EnumMember[] Members { get; }

        public EnumDefinition(string name, EnumMember[] elements)
        {
            Name = name;
            if (Name.EndsWith('_'))
            {
                FriendlyName = Name.Substring(0, Name.Length - 1);
            }
            else
            {
                FriendlyName = Name;
            }
            Members = elements;

            _sanitizedNames = new Dictionary<string, string>();
            foreach (EnumMember el in elements)
            {
                _sanitizedNames.Add(el.Name, SanitizeMemberName(el.Name));
            }
        }

        public string SanitizeNames(string text)
        {
            foreach (KeyValuePair<string, string> kvp in _sanitizedNames)
            {
                text = text.Replace(kvp.Key, kvp.Value);
            }

            return text;
        }

        private string SanitizeMemberName(string memberName)
        {
            string ret = memberName;
            if (memberName.StartsWith(Name))
            {
                ret = memberName.Substring(Name.Length);
            }

            if (ret.EndsWith('_'))
            {
                ret = ret.Substring(0, ret.Length - 1);
            }

            return ret;
        }
    }

    class EnumMember
    {
        public EnumMember(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public string Value { get; }
    }

    class TypeDefinition
    {
        public string Name { get; }
        public TypeReference[] Fields { get; }

        public TypeDefinition(string name, TypeReference[] fields)
        {
            Name = name;
            Fields = fields;
        }
    }

    class TypeReference
    {
        public string Name { get; }
        public string Type { get; }
        public string TemplateType { get; }
        public int ArraySize { get; }
        public bool IsFunctionPointer { get; }
        public string[] TypeVariants { get; }
        public bool IsEnum { get; }

        public TypeReference(string name, string type, EnumDefinition[] enums)
            : this(name, type, null, enums, null) { }

        public TypeReference(string name, string type, EnumDefinition[] enums, string[] typeVariants)
            : this(name, type, null, enums, typeVariants) { }

        public TypeReference(string name, string type, string templateType, EnumDefinition[] enums)
            : this(name, type, templateType, enums, null) { }

        public TypeReference(string name, string type, string templateType, EnumDefinition[] enums, string[] typeVariants)
        {
            Name = name;
            Type = type.Replace("const", string.Empty).Trim();


            if (Type.StartsWith("ImVector_"))
            {
                if (Type.EndsWith("*"))
                {
                    Type = "ImVector*";
                }
                else
                {
                    Type = "ImVector";
                }
            }

            TemplateType = templateType;
            int startBracket = name.IndexOf('[');
            if (startBracket != -1)
            {
                int endBracket = name.IndexOf(']');
                string sizePart = name.Substring(startBracket + 1, endBracket - startBracket - 1);
                ArraySize = ParseSizeString(sizePart, enums);
                Name = Name.Substring(0, startBracket);
            }

            IsFunctionPointer = Type.IndexOf('(') != -1;

            TypeVariants = typeVariants;

            IsEnum = enums.Any(t => t.Name == type || t.FriendlyName == type);
        }

        private int ParseSizeString(string sizePart, EnumDefinition[] enums)
        {
            int plusStart = sizePart.IndexOf('+');
            if (plusStart != -1)
            {
                string first = sizePart.Substring(0, plusStart);
                string second = sizePart.Substring(plusStart, sizePart.Length - plusStart);
                int firstVal = int.Parse(first);
                int secondVal = int.Parse(second);
                return firstVal + secondVal;
            }

            if (!int.TryParse(sizePart, out int ret))
            {
                foreach (EnumDefinition ed in enums)
                {
                    if (sizePart.StartsWith(ed.Name))
                    {
                        foreach (EnumMember member in ed.Members)
                        {
                            if (member.Name == sizePart)
                            {
                                return int.Parse(member.Value);
                            }
                        }
                    }
                }

                ret = -1;
            }

            return ret;
        }

        public TypeReference WithVariant(int variantIndex, EnumDefinition[] enums)
        {
            if (variantIndex == 0) return this;
            else return new TypeReference(Name, TypeVariants[variantIndex - 1], TemplateType, enums);
        }
    }

    class FunctionDefinition
    {
        public string Name { get; }
        public OverloadDefinition[] Overloads { get; }

        public FunctionDefinition(string name, OverloadDefinition[] overloads, EnumDefinition[] enums)
        {
            Name = name;
            Overloads = ExpandOverloadVariants(overloads, enums);
        }

        private OverloadDefinition[] ExpandOverloadVariants(OverloadDefinition[] overloads, EnumDefinition[] enums)
        {
            List<OverloadDefinition> newDefinitions = new List<OverloadDefinition>();

            foreach (OverloadDefinition overload in overloads)
            {
                bool hasVariants = false;
                int[] variantCounts = new int[overload.Parameters.Length];

                for (int i = 0; i < overload.Parameters.Length; i++)
                {
                    if (overload.Parameters[i].TypeVariants != null)
                    {
                        hasVariants = true;
                        variantCounts[i] = overload.Parameters[i].TypeVariants.Length + 1;
                    }
                    else
                    {
                        variantCounts[i] = 1;
                    }
                }

                if (hasVariants)
                {
                    int totalVariants = variantCounts[0];
                    for (int i = 1; i < variantCounts.Length; i++) totalVariants *= variantCounts[i];

                    for (int i = 0; i < totalVariants; i++)
                    {
                        TypeReference[] parameters = new TypeReference[overload.Parameters.Length];
                        int div = 1;

                        for (int j = 0; j < parameters.Length; j++)
                        {
                            int k = (i / div) % variantCounts[j];

                            parameters[j] = overload.Parameters[j].WithVariant(k, enums);

                            if (j > 0) div *= variantCounts[j];
                        }

                        newDefinitions.Add(overload.WithParameters(parameters));
                    }
                }
                else
                {
                    newDefinitions.Add(overload);
                }
            }

            return newDefinitions.ToArray();
        }
    }

    class OverloadDefinition
    {
        public string ExportedName { get; }
        public string FriendlyName { get; }
        public TypeReference[] Parameters { get; }
        public Dictionary<string, string> DefaultValues { get; }
        public string ReturnType { get; }
        public string StructName { get; }
        public bool IsMemberFunction { get; }
        public string Comment { get; }
        public bool IsConstructor { get; }
        public bool IsDestructor { get; }

        public OverloadDefinition(
            string exportedName,
            string friendlyName,
            TypeReference[] parameters,
            Dictionary<string, string> defaultValues,
            string returnType,
            string structName,
            string comment,
            bool isConstructor,
            bool isDestructor)
        {
            ExportedName = exportedName;
            FriendlyName = friendlyName;
            Parameters = parameters;
            DefaultValues = defaultValues;
            ReturnType = returnType.Replace("const", string.Empty).Replace("inline", string.Empty).Trim();
            StructName = structName;
            IsMemberFunction = !string.IsNullOrEmpty(structName);
            Comment = comment;
            IsConstructor = isConstructor;
            IsDestructor = isDestructor;
        }

        public OverloadDefinition WithParameters(TypeReference[] parameters)
        {
            return new OverloadDefinition(ExportedName, FriendlyName, parameters, DefaultValues, ReturnType, StructName, Comment, IsConstructor, IsDestructor);
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
