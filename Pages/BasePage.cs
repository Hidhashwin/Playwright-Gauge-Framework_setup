using Microsoft.Playwright;
using PlaywrightGaugeFramework.Drivers;
using PlaywrightGaugeFramework.Utilities;

namespace PlaywrightGaugeFramework.Pages;

public class BasePage
{
    protected IPage Page => DriverFactory.Page;

    public async Task NavigateToApplication(string applicationName)
    {
        var url = ConfigManager.GetBaseUrl(applicationName);
        await Page.GotoAsync(url);
    }
}