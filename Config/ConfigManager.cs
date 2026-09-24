using System.IO;
using Microsoft.Extensions.Configuration;

namespace PlaywrightGaugeFramework.Utilities;

public static class ConfigManager
{
    private static readonly IConfigurationRoot Configuration;

    static ConfigManager()
    {
        var masterConfig = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Config/appsettings.json", false, true)
            .Build();

        var application = masterConfig["Application"];

        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"Config/{application}.json", false, true)
            .Build();
    }

    public static string Browser =>
        Configuration["Browser"]!;

    public static bool Headless =>
        bool.Parse(Configuration["Headless"]!);

    public static string BaseUrl =>
        Configuration["BaseUrl"]!;

    public static int Timeout =>
        int.Parse(Configuration["Timeout"]!);
}