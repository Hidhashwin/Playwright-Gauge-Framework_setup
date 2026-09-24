using Gauge.CSharp.Lib.Attribute;
using PlaywrightGaugeFramework.Pages;

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
        await _loginPage.EnterUsername(username);
        await _loginPage.EnterPassword(password);
        await _loginPage.ClickLogin();
    }
}