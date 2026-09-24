using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using PlaywrightGaugeFramework.Utilities;



namespace PlaywrightGaugeFramework.Drivers;

public static class DriverFactory
{
    public static IPlaywright Playwright { get; private set; }
    public static IBrowser Browser { get; private set; }
    public static IBrowserContext Context { get; private set; }
    public static IPage Page { get; private set; }

    public static async Task InitializeBrowser()
{
    Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

    switch (ConfigManager.Browser.ToLower())
    {
        case "chrome":
            Browser = await Playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = ConfigManager.Headless,
                    Channel = "chrome"
                });
            break;

        case "edge":
            Browser = await Playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = ConfigManager.Headless,
                    Channel = "msedge"
                });
            break;

        case "firefox":
            Browser = await Playwright.Firefox.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = ConfigManager.Headless
                });
            break;

        case "webkit":
            Browser = await Playwright.Webkit.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = ConfigManager.Headless
                });
            break;

        default:
            throw new ArgumentException(
                $"Unsupported browser: {ConfigManager.Browser}");
    }

    Context = await Browser.NewContextAsync();
    Page = await Context.NewPageAsync();

    // Add here
    Page.SetDefaultTimeout(ConfigManager.Timeout);
    Page.SetDefaultNavigationTimeout(ConfigManager.Timeout);
}
public static async Task CloseBrowser()
{
    if (Browser != null)
    {
        await Browser.CloseAsync();
    }

    Playwright?.Dispose();
}
}