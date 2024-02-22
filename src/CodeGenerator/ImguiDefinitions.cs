using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace CodeGenerator
{
    class ImguiDefinitions
    {
        public EnumDefinition[] Enums;
        public TypeDefinition[] Types;
        public FunctionDefinition[] Functions;
        public Dictionary<string, MethodVariant> Variants;

        static int GetInt(JToken token, string key)
        {
            var v = token[key];
            if (v == null) return 0;
            return v.ToObject<int>();
        }
        public void LoadFrom(string directory)
        {
            
            JObject typesJson;
            using (StreamReader fs = File.OpenText(Path.Combine(directory, "structs_and_enums.json")))
            using (JsonTextReader jr = new JsonTextReader(fs))
            {
                typesJson = JObject.Load(jr);
            }

            JObject functionsJson;
            using (StreamReader fs = File.OpenText(Path.Combine(directory, "definitions.json")))
            using (JsonTextReader jr = new JsonTextReader(fs))
            {
                functionsJson = JObject.Load(jr);
            }

            JObject variantsJson = null;
            if (File.Exists(Path.Combine(directory, "variants.json")))
            {
                using (StreamReader fs = File.OpenText(Path.Combine(directory, "variants.json")))
                using (JsonTextReader jr = new JsonTextReader(fs))
                {
                    variantsJson = JObject.Load(jr);
                }
            }

            Variants = new Dictionary<string, MethodVariant>();
            foreach (var jt in variantsJson.Children())
            {
                JProperty jp = (JProperty)jt;
                ParameterVariant[] methodVariants = jp.Values().Select(jv =>
                {
                    return new ParameterVariant(jv["name"].ToString(), jv["type"].ToString(), jv["variants"].Select(s => s.ToString()).ToArray());
                }).ToArray();
                Variants.Add(jp.Name, new MethodVariant(jp.Name, methodVariants));
            }

            var typeLocations = typesJson["locations"];

            Enums = typesJson["enums"].Select(jt =>
            {
                JProperty jp = (JProperty)jt;
                string name = jp.Name;
                if (typeLocations?[jp.Name]?.Value<string>().Contains("internal") ?? false) {
                    return null;
                }
                EnumMember[] elements = jp.Values().Select(v =>
                {
                    return new EnumMember(v["name"].ToString(), v["calc_value"].ToString());
                }).ToArray();
                return new EnumDefinition(name, elements);
            }).Where(x => x != null).ToArray();

            Types = typesJson["structs"].Select(jt =>
            {
                JProperty jp = (JProperty)jt;
                string name = jp.Name;
                if (typeLocations?[jp.Name]?.Value<string>().Contains("internal") ?? false) {
                    return null;
                }
                TypeReference[] fields = jp.Values().Select(v =>
                {
                    if (v["type"].ToString().Contains("static")) { return null; }

                    
                    return new TypeReference(
                        v["name"].ToString(),
                        v["type"].ToString(),
                            GetInt(v, "size"),
                        v["template_type"]?.ToString(),
                        Enums);
                }).Where(tr => tr != null).ToArray();
                return new TypeDefinition(name, fields);
            }).Where(x => x != null).ToArray();

            Functions = functionsJson.Children().Select(jt =>
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
                    //skip internal functions
                    var typename = val["stname"]?.ToString();
                    if (!string.IsNullOrEmpty(typename))
                    {
                        if (!Types.Any(x => x.Name == val["stname"]?.ToString())) {
                            return null;
                        }
                    }
                    if (friendlyName == null) { return null; }
                    if (val["location"]?.ToString().Contains("internal") ?? false) return null;

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
                    Variants.TryGetValue(jp.Name, out methodVariants);

                    foreach (JToken p in val["argsT"])
                    {
                        string pType = p["type"].ToString();
                        string pName = p["name"].ToString();

                        // if there are possible variants for this method then try to match them based on the parameter name and expected type
                        ParameterVariant matchingVariant = methodVariants?.Parameters.Where(pv => pv.Name == pName && pv.OriginalType == pType).FirstOrDefault() ?? null;
                        if (matchingVariant != null) matchingVariant.Used = true;

                        parameters.Add(new TypeReference(pName, pType, 0, Enums, matchingVariant?.VariantTypes));
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
                if(overloads.Length == 0) return null;
                return new FunctionDefinition(name, overloads, Enums);
            }).Where(x => x != null).OrderBy(fd => fd.Name).ToArray();
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

        public string[] Names { get; }
        public string[] FriendlyNames { get; }
        public EnumMember[] Members { get; }

        public EnumDefinition(string name, EnumMember[] elements)
        {
            if (TypeInfo.AlternateEnumPrefixes.TryGetValue(name, out string altName))
            {
                Names = new[] { name, altName };
            }
            else
            {
                Names = new[] { name };
            }
            FriendlyNames = new string[Names.Length];
            for (int i = 0; i < Names.Length; i++)
            {
                string n = Names[i];
                if (n.EndsWith('_'))
                {
                    FriendlyNames[i] = n.Substring(0, n.Length - 1);
                }
                else
                {
                    FriendlyNames[i] = n;
                }

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
            bool altSubstitution = false;

            // Try alternate substitution first
            foreach (KeyValuePair<string, string> substitutionPair in TypeInfo.AlternateEnumPrefixSubstitutions)
            {
                if (memberName.StartsWith(substitutionPair.Key))
                {
                    ret = ret.Replace(substitutionPair.Key, substitutionPair.Value);
                    altSubstitution = true;
                    break;
                }
            }

            if (!altSubstitution)
            {
                foreach (string name in Names)
                {
                    if (memberName.StartsWith(name))
                    {
                        ret = memberName.Substring(name.Length);
                        if (ret.StartsWith("_"))
                        {
                            ret = ret.Substring(1);
                        }
                    }
                }
            }

            if (ret.EndsWith('_'))
            {
                ret = ret.Substring(0, ret.Length - 1);
            }

            if (char.IsDigit(ret.First()))
                ret = "_" + ret;

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

        public TypeReference(string name, string type, int asize, EnumDefinition[] enums)
            : this(name, type, asize, null, enums, null) { }

        public TypeReference(string name, string type, int asize, EnumDefinition[] enums, string[] typeVariants)
            : this(name, type, asize, null, enums, typeVariants) { }

        public TypeReference(string name, string type, int asize, string templateType, EnumDefinition[] enums)
            : this(name, type, asize, templateType, enums, null) { }

        public TypeReference(string name, string type, int asize, string templateType, EnumDefinition[] enums, string[] typeVariants)
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

            if (Type.StartsWith("ImChunkStream_"))
            {
                if (Type.EndsWith("*"))
                {
                    Type = "ImChunkStream*";
                }
                else
                {
                    Type = "ImChunkStream";
                }
            }

            TemplateType = templateType;
            ArraySize = asize;
            int startBracket = name.IndexOf('[');
            if (startBracket != -1)
            {
                //This is only for older cimgui binding jsons
                int endBracket = name.IndexOf(']');
                string sizePart = name.Substring(startBracket + 1, endBracket - startBracket - 1);
                if(ArraySize == 0)
                    ArraySize = ParseSizeString(sizePart, enums);
                Name = Name.Substring(0, startBracket);
            }
            IsFunctionPointer = Type.IndexOf('(') != -1;
            
            TypeVariants = typeVariants;

            IsEnum = enums.Any(t => t.Names.Contains(type) || t.FriendlyNames.Contains(type) || TypeInfo.WellKnownEnums.Contains(type));
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
                    if (ed.Names.Any(n => sizePart.StartsWith(n)))
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
            else return new TypeReference(Name, TypeVariants[variantIndex - 1], ArraySize, TemplateType, enums);
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
}
