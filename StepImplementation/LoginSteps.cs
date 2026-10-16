using Gauge.CSharp.Lib.Attribute;
using PlaywrightGaugeFramework.Pages;
using PlaywrightGaugeFramework.Utilities;

namespace PlaywrightGaugeFramework.StepImplementation;

public class LoginSteps
{
    private readonly LoginPage _loginPage = new();

    [Step("Open Guru99 application")]
    public async Task OpenApplication()
    {
        await _loginPage.NavigateToApplication();
    }

    [Step("Login with username <username> and password <password>")]
    public async Task Login(string username, string password)
    {
    try
    {
    await _loginPage.EnterUsername(username);
    await _loginPage.EnterPassword(password);
    await _loginPage.ClickLogin();
    }
    catch (Exception)
    {
    await ScreenshotHelper.CaptureScreenshot("LoginFailed");
    throw;
}
    
}
[Step("Then wait for <seconds> seconds")]
public async Task WaitForSeconds(int seconds)
{
    await _loginPage.PauseExecution(seconds);
}
[Step("Pause execution for <seconds> seconds")]
public async Task PauseExecution(int seconds)
{
    await _loginPage.PauseExecution(seconds);
}

}