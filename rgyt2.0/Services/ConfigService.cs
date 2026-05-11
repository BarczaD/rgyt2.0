using rgyt2._0.Models.Configuration;
using System.Text.Json;

namespace rgyt2._0.Services
{
    public class ConfigService
    {
        private const string ConfigFileName = "appsettings.json";

        public AppConfig Settings { get; private set; } = new();

        public void Load()
        {
            if (!File.Exists(ConfigFileName))
            {
                Save();
                return;
            }

            var json = File.ReadAllText(ConfigFileName);
            Settings = JsonSerializer.Deserialize<AppConfig>(json)
                       ?? new AppConfig();
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(
                Settings,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(ConfigFileName, json);
        }
    }
}
