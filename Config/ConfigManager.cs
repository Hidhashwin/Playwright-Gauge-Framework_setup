using System.IO;
using Microsoft.Extensions.Configuration;

namespace PlaywrightGaugeFramework.Utilities;

public static class ConfigManager
{
    private static readonly IConfigurationRoot Configuration;

    static ConfigManager()
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Config/appsettings.json", false, true)
            .Build();
    }

    public static string Browser =>
        Configuration["Browser"]!;

    public static bool Headless =>
        bool.Parse(Configuration["Headless"]!);

    public static int Timeout =>
        int.Parse(Configuration["Timeout"]!);

    public static string GetBaseUrl(string applicationName)
    {
        return Configuration[$"Applications:{applicationName}:BaseUrl"]!;
    }
}