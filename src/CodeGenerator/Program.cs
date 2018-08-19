using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    class Program
    {
        private static readonly Dictionary<string, string> s_wellKnownTypes = new Dictionary<string, string>()
        {
            // { "bool", "Bool8" },
            { "bool", "byte" },
            { "unsigned char", "byte" },
            { "char", "byte" },
            { "ImWchar", "ushort" },
            { "unsigned short", "ushort" },
            { "unsigned int", "uint" },
            { "ImVec2", "Vector2" },
            { "ImVec3", "Vector3" },
            { "ImVec4", "Vector4" },
            { "ImTextureID", "IntPtr" },
            { "ImGuiID", "uint" },
            { "ImDrawIdx", "ushort" },
            { "ImDrawListSharedData", "IntPtr" },
            { "ImU32", "uint" },
            { "ImDrawCallback", "IntPtr" },
            { "size_t", "uint" },
            { "ImGuiContext*", "IntPtr" },
            { "float[2]", "float*" },
            { "float[3]", "float*" },
            { "float[4]", "float*" },
            { "int[2]", "int*" },
            { "int[3]", "int*" },
            { "int[4]", "int*" },
            { "float&", "float*" },
            { "ImVec2[2]", "Vector2*" },
            { "char* []", "byte**" },

            // TODO: These shouldn't exist
            { "ImVector_ImWchar", "ImVector" },
            { "ImVector_TextRange", "ImVector" },
            { "ImVector_TextRange&", "ImVector*" },
        };

        private static readonly HashSet<string> s_customDefinedTypes = new HashSet<string>()
        {
            "ImVector",
            "ImVec2",
            "ImVec4",
            "Pair",
        };

        private static readonly Dictionary<string, string> s_wellKnownDefaultValues = new Dictionary<string, string>()
        {
            { "((void *)0)", "null" },
            { "ImVec2(0,0)", "new Vector2()" },
            { "ImVec2(-1,0)", "new Vector2(-1, 0)" },
            { "ImVec2(1,0)", "new Vector2(1, 0)" },
            { "ImVec2(1,1)", "new Vector2(1, 1)" },
            { "ImVec2(0,1)", "new Vector2(0, 1)" },
            { "ImVec4(0,0,0,0)", "new Vector4()" },
            { "ImVec4(1,1,1,1)", "new Vector4(1, 1, 1, 1)" },
            { "ImDrawCornerFlags_All", "(int)ImDrawCornerFlags.All" },
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
            "char",
            "float",
            "int",
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
                    return new TypeReference(v["name"].ToString(), v["type"].ToString(), enums);
                }).ToArray();
                return new TypeDefinition(name, fields);
            }).ToArray();

            FunctionDefinition[] functions = functionsJson.Children().Select(jt =>
            {
                JProperty jp = (JProperty)jt;
                string name = jp.Name;

                OverloadDefinition[] overloads = jp.Values().Select(val =>
                {
                    string ov_cimguiname = val["ov_cimguiname"]?.ToString();
                    string cimguiname = val["cimguiname"].ToString();
                    string friendlyName = val["funcname"].ToString();

                    string exportedName = ov_cimguiname;
                    if (exportedName == null)
                    {
                        exportedName = cimguiname;
                    }

                    string selfTypeName = null;
                    int underscoreIndex = exportedName.IndexOf('_');
                    if (underscoreIndex > 0 && !exportedName.StartsWith("ig")) // Hack to exclude some weirdly-named non-instance functions.
                    {
                        selfTypeName = exportedName.Substring(0, underscoreIndex);
                    }

                    List<TypeReference> parameters = new List<TypeReference>();
                    if (selfTypeName != null)
                    {
                        parameters.Add(new TypeReference("self", selfTypeName + "*", enums));
                    }

                    foreach (JToken p in val["argsT"])
                    {
                        string pType = p["type"].ToString();
                        string pName = p["name"].ToString();
                        parameters.Add(new TypeReference(pName, pType, enums));
                    }

                    Dictionary<string, string> defaultValues = new Dictionary<string, string>();
                    foreach (JToken dv in val["defaults"])
                    {
                        JProperty dvProp = (JProperty)dv;
                        defaultValues.Add(dvProp.Name, dvProp.Value.ToString());
                    }
                    string returnType = val["ret"]?.ToString() ?? "void";
                    string comment = null;

                    bool isMemberFunction = val["stname"].ToString() != "ImGui";

                    return new OverloadDefinition(
                        exportedName,
                        friendlyName,
                        parameters.ToArray(),
                        defaultValues,
                        returnType,
                        isMemberFunction,
                        comment,
                        enums);
                }).ToArray();

                return new FunctionDefinition(name, overloads);
            }).ToArray();

            foreach (EnumDefinition ed in enums)
            {
                using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, ed.FriendlyName + ".gen.cs")))
                {
                    writer.PushBlock("namespace ImGuiNET");
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
                    writer.WriteLine(string.Empty);
                    writer.PushBlock("namespace ImGuiNET");
                    writer.PushBlock($"public unsafe struct {td.Name}");
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
                writer.PushBlock("public unsafe static partial class ImGuiNative");
                foreach (FunctionDefinition fd in functions)
                {
                    foreach (OverloadDefinition overload in fd.Overloads)
                    {
                        string exportedName = overload.ExportedName;
                        if (exportedName.Contains("~")) { continue; }
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

                        writer.WriteLine("[DllImport(\"cimgui\")]");
                        writer.WriteLine($"public static extern {ret} {exportedName}({parameters});");
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
                writer.Using("static ImGuiNET.ImGuiNative");
                writer.WriteLine(string.Empty);
                writer.PushBlock("namespace ImGuiNET");
                writer.PushBlock("public unsafe static partial class ImGui");
                foreach (FunctionDefinition fd in functions)
                {
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
                            Dictionary<string, string> defaults = new Dictionary<string, string>();
                            for (int j = 0; j < i; j++)
                            {
                                defaults.Add(orderedDefaults[j].Key, orderedDefaults[j].Value);
                            }
                            EmitOverload(writer, overload, defaults);
                        }
                    }
                }
                writer.PopBlock();
                writer.PopBlock();
            }
        }

        private static int GetIndex(TypeReference[] parameters, string key)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                if (key == parameters[i].Name) { return i; }
            }

            throw new InvalidOperationException();
        }

        private static void EmitOverload(CSharpCodeWriter writer, OverloadDefinition overload, Dictionary<string, string> defaultValues)
        {
            if (overload.Parameters.Length > 0 && overload.Parameters[0].Name == "self") { return; }

            string nativeRet = GetTypeString(overload.ReturnType, false);
            string safeRet = GetSafeType(overload.ReturnType);

            List<string> invocationArgs = new List<string>();
            MarshalledParameter[] marshalledParameters = new MarshalledParameter[overload.Parameters.Length];
            List<string> preCallLines = new List<string>();
            List<string> postCallLines = new List<string>();
            List<string> byRefParams = new List<string>();
            for (int i = 0; i < overload.Parameters.Length; i++)
            {
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
                        preCallLines.Add($"int {correctedIdentifier}_byteCount = Encoding.UTF8.GetByteCount({textToEncode});");
                        preCallLines.Add($"byte* {nativeArgName} = stackalloc byte[{correctedIdentifier}_byteCount + 1];");
                        preCallLines.Add($"fixed (char* {correctedIdentifier}_ptr = {textToEncode})");
                        preCallLines.Add("{");
                        preCallLines.Add($"    int {nativeArgName}_offset = Encoding.UTF8.GetBytes({correctedIdentifier}_ptr, {textToEncode}.Length, {nativeArgName}, {correctedIdentifier}_byteCount);");
                        preCallLines.Add($"    {nativeArgName}[{nativeArgName}_offset] = 0;");
                        preCallLines.Add("}");
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
                    preCallLines.Add($"        offset += 1;");
                    preCallLines.Add($"        {nativeArgName}_data[offset] = 0;");
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
                else if (tr.Type.EndsWith("*") && tr.Type != "void*" && !s_wellKnownTypes.ContainsKey(tr.Type))
                {
                    string nonPtrType = GetTypeString(tr.Type.Substring(0, tr.Type.Length - 1), false);
                    string nativeArgName = "native_" + tr.Name;
                    marshalledParameters[i] = new MarshalledParameter($"ref {nonPtrType}", false, nativeArgName, false);
                    preCallLines.Add($"{nonPtrType} {nativeArgName}_val = {correctedIdentifier};");
                    preCallLines.Add($"{nonPtrType}* {nativeArgName} = &{nativeArgName}_val;");
                    postCallLines.Add($"{correctedIdentifier} = {nativeArgName}_val;");
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

            string friendlyName = overload.IsMemberFunction ? overload.ExportedName : overload.FriendlyName;

            if (overload.IsMemberFunction)
            {

            }

            writer.PushBlock($"public static {safeRet} {friendlyName}({invocationList})");

            foreach (string line in preCallLines)
            {
                writer.WriteLine(line);
            }

            List<string> nativeInvocationArgs = new List<string>();

            for (int i = 0; i < marshalledParameters.Length; i++)
            {
                TypeReference tr = overload.Parameters[i];
                MarshalledParameter mp = marshalledParameters[i];
                if (mp == null) { continue; }
                if (mp.IsPinned)
                {
                    string nativePinType = GetTypeString(tr.Type, false);
                    writer.PushBlock($"fixed ({nativePinType} native_{tr.Name} = native_{tr.Name}_topin)");
                }

                nativeInvocationArgs.Add(mp.VarName);
            }

            string nativeInvocationStr = string.Join(", ", nativeInvocationArgs);
            string ret = safeRet == "void" ? string.Empty : $"{nativeRet} ret = ";
            writer.WriteLine($"{ret}ImGuiNative.{overload.ExportedName}({nativeInvocationStr});");

            for (int i = 0; i < marshalledParameters.Length; i++)
            {
                MarshalledParameter mp = marshalledParameters[i];
                if (mp == null) { continue; }
                if (mp.IsPinned)
                {
                    writer.PopBlock();
                }
            }

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
                else
                {
                    writer.WriteLine($"return ret;");
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

            return GetTypeString(nativeRet, false);
        }

        private static string GetSafeType(TypeReference typeRef)
        {
            return typeRef.Type;
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

            correctedDefault = defaultVal;
            return true;
        }

        private static string GetTypeString(string typeName, bool isFunctionPointer)
        {
            int pointerLevel = 0;
            if (typeName.EndsWith("**")) { pointerLevel = 2; }
            else if (typeName.EndsWith("*")) { pointerLevel = 1; }

            if (s_wellKnownTypes.TryGetValue(typeName.Substring(0, typeName.Length - pointerLevel), out string typeStr))
            {
                typeStr = typeStr + new string('*', pointerLevel);
            }
            else if (!s_wellKnownTypes.TryGetValue(typeName, out typeStr))
            {
                typeStr = typeName;
                if (isFunctionPointer) { typeStr = "IntPtr"; }
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
        public int ArraySize { get; }
        public bool IsFunctionPointer { get; }

        public TypeReference(string name, string type, EnumDefinition[] enums)
        {
            Name = name;
            Type = type.Replace("const", string.Empty).Trim();
            int startBracket = name.IndexOf('[');
            if (startBracket != -1)
            {
                int endBracket = name.IndexOf(']');
                string sizePart = name.Substring(startBracket + 1, endBracket - startBracket - 1);
                ArraySize = ParseSizeString(sizePart, enums);
                Name = Name.Substring(0, startBracket);
            }

            IsFunctionPointer = Type.IndexOf('(') != -1;
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
    }

    class FunctionDefinition
    {
        public string Name { get; }
        public OverloadDefinition[] Overloads { get; }

        public FunctionDefinition(string name, OverloadDefinition[] overloads)
        {
            Name = name;
            Overloads = overloads;
        }
    }

    class OverloadDefinition
    {
        public string ExportedName { get; }
        public string FriendlyName { get; }
        public TypeReference[] Parameters { get; }
        public Dictionary<string, string> DefaultValues { get; }
        public string ReturnType { get; }
        public bool IsMemberFunction { get; }
        public string Comment { get; }

        public OverloadDefinition(
            string exportedName,
            string friendlyName,
            TypeReference[] parameters,
            Dictionary<string, string> defaultValues,
            string returnType,
            bool isMemberFunction,
            string comment,
            EnumDefinition[] enums)
        {
            ExportedName = exportedName;
            FriendlyName = friendlyName;
            Parameters = parameters;
            DefaultValues = defaultValues;
            ReturnType = returnType.Replace("const", string.Empty).Replace("inline", string.Empty).Trim();
            IsMemberFunction = isMemberFunction;
            Comment = comment;
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
    }
}
