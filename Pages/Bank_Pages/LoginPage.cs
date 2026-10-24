    using PlaywrightGaugeFramework.Utilities;
    using Microsoft.Playwright; 

    namespace PlaywrightGaugeFramework.Pages;

    public class LoginPage : BasePage
    {
      
        public async Task EnterUsername(string username)
        {
        await Page.FillAsync("input[name='uid']", username);
        }

        public async Task EnterPassword(string password)
        {
            await Page.FillAsync("input[name='password']", password);
        }

        public async Task ClickLogin()
        {
            await Page.ClickAsync("input[name='btnLogin']");
        }
        public async Task PauseExecution(int seconds)
{
    await Page.WaitForTimeoutAsync(seconds * 1000);
}
    }   
