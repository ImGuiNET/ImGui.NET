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
            { "ImWchar", "char" },
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

            // TODO: These shouldn't exist
            { "ImVector_ImWchar*", "ImVector" },
            { "ImVector_TextRange", "ImVector" },
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
        };

        private static readonly Dictionary<string, string> s_identifierReplacements = new Dictionary<string, string>()
        {
            { "in", "@in" },
            { "out", "@out" },
            { "ref", "@ref" },
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
                    string exportedName = val["ov_cimguiname"]?.ToString();
                    if (exportedName == null)
                    {
                        exportedName = val["cimguiname"].ToString();
                    }
                    string parameters = val["args"].ToString();

                    if (name == "igCombo")
                    {

                    }

                    parameters = parameters.Substring(1, parameters.Length - 2);
                    Dictionary<string, string> defaultValues = new Dictionary<string, string>();
                    foreach (JToken dv in val["defaults"])
                    {
                        JProperty dvProp = (JProperty)dv;
                        defaultValues.Add(dvProp.Name, dvProp.Value.ToString());
                    }
                    string returnType = val["ret"]?.ToString() ?? "void";
                    string comment = null;



                    return new OverloadDefinition(exportedName, parameters, defaultValues, returnType, comment, enums);
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
                            writer.WriteLine($"public fixed {typeStr} {field.Name}[{field.ArraySize}];");
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

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "Functions.gen.cs")))
            {
                writer.Using("System");
                writer.Using("System.Numerics");
                writer.Using("System.Runtime.InteropServices");
                writer.WriteLine(string.Empty);
                writer.PushBlock("namespace ImGuiNET");
                writer.PushBlock("public unsafe static class ImGuiNative");
                foreach (FunctionDefinition fd in functions)
                {
                    foreach (OverloadDefinition overload in fd.Overloads)
                    {
                        string name = overload.ExportedName;
                        if (name.Contains("~")) { continue; }
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
                        writer.WriteLine($"public static extern {ret} {name}({parameters});");
                    }
                }
                writer.PopBlock();
                writer.PopBlock();
            }
        }

        private static bool CorrectDefaultValue(string defaultVal, TypeReference tr, out string correctedDefault)
        {
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
        public TypeReference[] Parameters { get; }
        public Dictionary<string, string> DefaultValues { get; }
        public string ReturnType { get; }
        public string Comment { get; }

        public OverloadDefinition(
            string exportedName,
            TypeReference[] parameters,
            Dictionary<string, string> defaultValues,
            string returnType,
            string comment,
            EnumDefinition[] enums)
        {
            ExportedName = exportedName;
            Parameters = parameters;
            DefaultValues = defaultValues;
            ReturnType = returnType.Replace("const", string.Empty).Replace("inline", string.Empty).Trim();
            Comment = comment;
        }
    }
}
