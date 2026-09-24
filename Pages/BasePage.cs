using Microsoft.Playwright;
using PlaywrightGaugeFramework.Drivers;

namespace PlaywrightGaugeFramework.Pages;

public class BasePage
{
    protected IPage Page => DriverFactory.Page;
}