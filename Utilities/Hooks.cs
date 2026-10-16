using Gauge.CSharp.Lib.Attribute;
using PlaywrightGaugeFramework.Drivers;

namespace PlaywrightGaugeFramework.Utilities;

public class Hooks
{
    [BeforeScenario]
    public async Task BeforeScenario()
    {
        await DriverFactory.InitializeBrowser();
    }

    [AfterScenario]
    public async Task AfterScenario()
    {
        await DriverFactory.CloseBrowser();
    }
}   