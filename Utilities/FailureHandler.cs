namespace PlaywrightGaugeFramework.Utilities;

public static class FailureHandler
{
    public static async Task HandleFailure(string screenshotName)
    {
        await ScreenshotHelper.CaptureScreenshot(screenshotName);
    }
}