using Microsoft.Playwright;
using PlaywrightGaugeFramework.Drivers;

namespace PlaywrightGaugeFramework.Utilities;

public static class ScreenshotHelper
{
    public static async Task<string> CaptureScreenshot(string screenshotName)
    {
        string folderPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "reports",
            "screenshots");

        Directory.CreateDirectory(folderPath);

        string filePath = Path.Combine(
            folderPath,
            $"{screenshotName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");

        await DriverFactory.Page.ScreenshotAsync(
            new PageScreenshotOptions
            {
                Path = filePath,
                FullPage = true
            });

        Console.WriteLine($"Screenshot saved: {filePath}");

        return filePath;
    }
}   