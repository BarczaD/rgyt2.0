using rgyt2._0.Models.Configuration;
using System.Text.Json;

public class ConfigService
{
    public AppConfig Config { get; private set; } = new();

    public void Load()
    {
        var baseDir = AppContext.BaseDirectory;
        var configPath = Path.Combine(baseDir, "appsettings.json");

        var json = File.ReadAllText(configPath);
        Config = JsonSerializer.Deserialize<AppConfig>(json)!;

        Config.Database.DbfFolder =
            Path.GetFullPath(Path.Combine(baseDir, Config.Database.DbfFolder));

        Config.Database.SqliteFile =
            Path.GetFullPath(Path.Combine(baseDir, Config.Database.SqliteFile));
    }
}