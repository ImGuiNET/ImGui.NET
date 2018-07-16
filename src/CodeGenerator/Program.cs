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
            { "bool", "Bool8" },
            { "unsigned char", "byte" },
            { "char", "byte" },
            { "ImWchar", "char" },
            { "unsigned int", "uint" },
            { "ImVec2", "Vector2" },
            { "ImVec3", "Vector3" },
            { "ImVec4", "Vector4" },
        };

        private static readonly Dictionary<string, string> s_wellKnownDefaultValues = new Dictionary<string, string>()
        {
            { "((void *)0)", "null" },
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

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "functions.gen.cs")))
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
                        string ret = GetTypeString(overload.ReturnType, false);
                        string name = overload.ExportedName;

                        StringBuilder paramsBuilder = new StringBuilder();
                        for (int i = 0; i < overload.Parameters.Length; i++)
                        {
                            if (overload.Parameters.Last().Name == "...")
                            {
                                continue;
                            }

                            TypeReference p = overload.Parameters[i];
                            string paramType = GetTypeString(p.Type, p.IsFunctionPointer);
                            paramsBuilder.Append(paramType);
                            paramsBuilder.Append(' ');
                            paramsBuilder.Append(p.Name);

                            if (overload.DefaultValues.TryGetValue(p.Name, out string defaultVal))
                            {
                                if (s_wellKnownDefaultValues.TryGetValue(defaultVal, out string correctedDefault))
                                {
                                    defaultVal = correctedDefault;
                                }

                                if (!defaultVal.Contains("%")) // TODO: Can't handle this right now.
                                {
                                    paramsBuilder.Append(" = ");
                                    paramsBuilder.Append(defaultVal);
                                }
                            }

                            if (i != overload.Parameters.Length - 1)
                            {
                                paramsBuilder.Append(", ");
                            }
                        }
                        string parameters = paramsBuilder.ToString();

                        writer.WriteLine("[DllImport(\"cimgui\")]");
                        writer.WriteLine($"public static extern {ret} {name}({parameters});");
                    }
                }
                writer.PopBlock();
                writer.PopBlock();
            }
        }

        private static string GetTypeString(string typeName, bool isFunctionPointer)
        {
            if (!s_wellKnownTypes.TryGetValue(typeName, out string typeStr))
            {
                int pointerLevel = 0;
                if (typeName.EndsWith("**")) { pointerLevel = 2; }
                else if (typeName.EndsWith("*")) { pointerLevel = 1; }

                if (pointerLevel > 0 && s_wellKnownTypes.TryGetValue(typeName.Substring(0, typeName.Length - pointerLevel), out typeStr))
                {
                    typeStr = typeStr + new string('*', pointerLevel);
                }
                else
                {
                    typeStr = typeName;
                    if (isFunctionPointer) { typeStr = "IntPtr"; }
                }
            }

            return typeStr;
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
            string parameters,
            Dictionary<string, string> defaultValues,
            string returnType,
            string comment,
            EnumDefinition[] enums)
        {
            ExportedName = exportedName;
            string[] commaSplit = parameters.Split(',', StringSplitOptions.RemoveEmptyEntries);
            Parameters = new TypeReference[commaSplit.Length];
            for (int i = 0; i < commaSplit.Length; i++)
            {
                string[] spaceSplit = commaSplit[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = spaceSplit.Last();
                string type = string.Join(' ', spaceSplit.Take(spaceSplit.Length - 1));
                Parameters[i] = new TypeReference(name, type, enums);
            }
            DefaultValues = defaultValues;
            ReturnType = returnType;
            Comment = comment;
        }
    }
}
