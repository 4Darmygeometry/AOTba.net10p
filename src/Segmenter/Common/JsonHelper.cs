using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace JiebaNet.Segmenter.Common
{
    public static class JsonHelper
    {
        public static IDictionary<char, IDictionary<char, double>> ParseCharCharDoubleDict(string jsonFilePath)
        {
            var jsonText = File.ReadAllText(jsonFilePath);
            return ParseCharCharDoubleDictCore(jsonText);
        }

        public static async Task<IDictionary<char, IDictionary<char, double>>> ParseCharCharDoubleDictAsync(string jsonFilePath)
        {
            var jsonText = await File.ReadAllTextAsync(jsonFilePath).ConfigureAwait(false);
            return ParseCharCharDoubleDictCore(jsonText);
        }

        private static IDictionary<char, IDictionary<char, double>> ParseCharCharDoubleDictCore(string jsonText)
        {
            var result = new Dictionary<char, IDictionary<char, double>>();
            using var doc = JsonDocument.Parse(jsonText);
            foreach (var outerProp in doc.RootElement.EnumerateObject())
            {
                if (outerProp.Name.Length != 1)
                    continue;
                var outerKey = outerProp.Name[0];
                var innerDict = new Dictionary<char, double>();
                foreach (var innerProp in outerProp.Value.EnumerateObject())
                {
                    if (innerProp.Name.Length != 1)
                        continue;
                    innerDict[innerProp.Name[0]] = innerProp.Value.GetDouble();
                }
                result[outerKey] = innerDict;
            }
            return result;
        }

        public static IDictionary<string, double> ParseStringDoubleDict(string jsonFilePath)
        {
            var jsonText = File.ReadAllText(jsonFilePath);
            return ParseStringDoubleDictCore(jsonText);
        }

        public static async Task<IDictionary<string, double>> ParseStringDoubleDictAsync(string jsonFilePath)
        {
            var jsonText = await File.ReadAllTextAsync(jsonFilePath).ConfigureAwait(false);
            return ParseStringDoubleDictCore(jsonText);
        }

        private static IDictionary<string, double> ParseStringDoubleDictCore(string jsonText)
        {
            var result = new Dictionary<string, double>();
            using var doc = JsonDocument.Parse(jsonText);
            foreach (var prop in doc.RootElement.EnumerateObject())
            {
                result[prop.Name] = prop.Value.GetDouble();
            }
            return result;
        }

        public static IDictionary<string, IDictionary<string, double>> ParseStringStringDoubleDict(string jsonFilePath)
        {
            var jsonText = File.ReadAllText(jsonFilePath);
            return ParseStringStringDoubleDictCore(jsonText);
        }

        public static async Task<IDictionary<string, IDictionary<string, double>>> ParseStringStringDoubleDictAsync(string jsonFilePath)
        {
            var jsonText = await File.ReadAllTextAsync(jsonFilePath).ConfigureAwait(false);
            return ParseStringStringDoubleDictCore(jsonText);
        }

        private static IDictionary<string, IDictionary<string, double>> ParseStringStringDoubleDictCore(string jsonText)
        {
            var result = new Dictionary<string, IDictionary<string, double>>();
            using var doc = JsonDocument.Parse(jsonText);
            foreach (var outerProp in doc.RootElement.EnumerateObject())
            {
                var innerDict = new Dictionary<string, double>();
                foreach (var innerProp in outerProp.Value.EnumerateObject())
                {
                    innerDict[innerProp.Name] = innerProp.Value.GetDouble();
                }
                result[outerProp.Name] = innerDict;
            }
            return result;
        }

        public static IDictionary<string, IDictionary<char, double>> ParseStringCharDoubleDict(string jsonFilePath)
        {
            var jsonText = File.ReadAllText(jsonFilePath);
            return ParseStringCharDoubleDictCore(jsonText);
        }

        public static async Task<IDictionary<string, IDictionary<char, double>>> ParseStringCharDoubleDictAsync(string jsonFilePath)
        {
            var jsonText = await File.ReadAllTextAsync(jsonFilePath).ConfigureAwait(false);
            return ParseStringCharDoubleDictCore(jsonText);
        }

        private static IDictionary<string, IDictionary<char, double>> ParseStringCharDoubleDictCore(string jsonText)
        {
            var result = new Dictionary<string, IDictionary<char, double>>();
            using var doc = JsonDocument.Parse(jsonText);
            foreach (var outerProp in doc.RootElement.EnumerateObject())
            {
                var innerDict = new Dictionary<char, double>();
                foreach (var innerProp in outerProp.Value.EnumerateObject())
                {
                    if (innerProp.Name.Length != 1)
                        continue;
                    innerDict[innerProp.Name[0]] = innerProp.Value.GetDouble();
                }
                result[outerProp.Name] = innerDict;
            }
            return result;
        }

        public static IDictionary<char, List<string>> ParseCharStringListDict(string jsonFilePath)
        {
            var jsonText = File.ReadAllText(jsonFilePath);
            return ParseCharStringListDictCore(jsonText);
        }

        public static async Task<IDictionary<char, List<string>>> ParseCharStringListDictAsync(string jsonFilePath)
        {
            var jsonText = await File.ReadAllTextAsync(jsonFilePath).ConfigureAwait(false);
            return ParseCharStringListDictCore(jsonText);
        }

        private static IDictionary<char, List<string>> ParseCharStringListDictCore(string jsonText)
        {
            var result = new Dictionary<char, List<string>>();
            using var doc = JsonDocument.Parse(jsonText);
            foreach (var prop in doc.RootElement.EnumerateObject())
            {
                if (prop.Name.Length != 1)
                    continue;
                var list = new List<string>();
                foreach (var item in prop.Value.EnumerateArray())
                {
                    list.Add(item.GetString()!);
                }
                result[prop.Name[0]] = list;
            }
            return result;
        }

        public static Dictionary<char, double> ParseCharDoubleDict(string jsonFilePath)
        {
            var jsonText = File.ReadAllText(jsonFilePath);
            return ParseCharDoubleDictCore(jsonText);
        }

        public static async Task<Dictionary<char, double>> ParseCharDoubleDictAsync(string jsonFilePath)
        {
            var jsonText = await File.ReadAllTextAsync(jsonFilePath).ConfigureAwait(false);
            return ParseCharDoubleDictCore(jsonText);
        }

        private static Dictionary<char, double> ParseCharDoubleDictCore(string jsonText)
        {
            var result = new Dictionary<char, double>();
            using var doc = JsonDocument.Parse(jsonText);
            foreach (var prop in doc.RootElement.EnumerateObject())
            {
                if (prop.Name.Length != 1)
                    continue;
                result[prop.Name[0]] = prop.Value.GetDouble();
            }
            return result;
        }

        public static Dictionary<string, List<string>> ParseStringStringListDict(string jsonFilePath)
        {
            var jsonText = File.ReadAllText(jsonFilePath);
            return ParseStringStringListDictCore(jsonText);
        }

        public static async Task<Dictionary<string, List<string>>> ParseStringStringListDictAsync(string jsonFilePath)
        {
            var jsonText = await File.ReadAllTextAsync(jsonFilePath).ConfigureAwait(false);
            return ParseStringStringListDictCore(jsonText);
        }

        private static Dictionary<string, List<string>> ParseStringStringListDictCore(string jsonText)
        {
            var result = new Dictionary<string, List<string>>();
            using var doc = JsonDocument.Parse(jsonText);
            foreach (var prop in doc.RootElement.EnumerateObject())
            {
                var list = new List<string>();
                foreach (var item in prop.Value.EnumerateArray())
                {
                    list.Add(item.GetString()!);
                }
                result[prop.Name] = list;
            }
            return result;
        }

        public static string SerializeCharDoubleDict(IDictionary<char, double> dict)
        {
            var sb = new System.Text.StringBuilder();
            sb.Append('{');
            var first = true;
            foreach (var kvp in dict)
            {
                if (!first)
                {
                    sb.Append(',');
                }
                first = false;
                sb.Append('"');
                sb.Append(EscapeChar(kvp.Key));
                sb.Append('"');
                sb.Append(':');
                sb.Append(kvp.Value.ToString("R", System.Globalization.CultureInfo.InvariantCulture));
            }
            sb.Append('}');
            return sb.ToString();
        }

        private static string EscapeChar(char c)
        {
            return c switch
            {
                '"' => "\\\"",
                '\\' => "\\\\",
                '\b' => "\\b",
                '\f' => "\\f",
                '\n' => "\\n",
                '\r' => "\\r",
                '\t' => "\\t",
                _ when c < ' ' => $"\\u{(int)c:X4}",
                _ => c.ToString()
            };
        }
    }
}
