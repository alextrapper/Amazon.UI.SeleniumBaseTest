using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Amazon.UI.SeleniumBaseTests.Helpers.Config
{
    internal static class ConfigHelper
    {
        private const string configFileName = "AppConfig.json";
        internal static AppConfig Get()
        {
            string jsonString = GetJSONString();
            return ConvertJsonToAppConfig(jsonString);
        }

        private static AppConfig ConvertJsonToAppConfig(string jsonString)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            return JsonSerializer.Deserialize<AppConfig>(jsonString, options);
        }

        private static string GetJSONString()
        {
            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(directory, configFileName);
            return File.ReadAllText(path);
        }
    }
}
