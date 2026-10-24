
using PlaywrightGaugeFramework.Utilities;
using System.Globalization;
using Microsoft.Playwright; 

namespace PlaywrightGaugeFramework.Pages;

public class AddCustomerPage : BasePage
{
public async Task ClickNewCustomer()
    {
    await Page.ClickAsync("//a[text()='New Customer']");
    }

public async Task EnterCustomerName(string custname)
    {
    await Page.FillAsync("//input[@name='name']", custname);
    }
public async Task SelectGender(string gender)
    {
    if (gender.Equals("male", StringComparison.OrdinalIgnoreCase))
    {
        await Page.ClickAsync("(//input[@type='radio'])[1]");
    }
    else if (gender.Equals("female", StringComparison.OrdinalIgnoreCase))
    {
        await Page.ClickAsync("(//input[@type='radio'])[2]");
    }
    else    
    {
        throw new ArgumentException($"Invalid gender: {gender}");
    }
    }
public async Task EnterDOB(string dob)
    {
    DateTime date = DateTime.ParseExact(dob,"dd-MM-yyyy",CultureInfo.InvariantCulture);
    await Page.FillAsync("#dob",date.ToString("yyyy-MM-dd"));
    }
public async Task EnterAddress(string address)
    {
    await Page.FillAsync("//textarea[@name='addr']", address);
    }
public async Task EnterCity(string city)
    {
    await Page.FillAsync("//input[@name='city']", city);
    }
public async Task EnterState(string state)
    {
    await Page.FillAsync("//input[@name='state']", state);
    }
public async Task EnterPin(string pin)
    {
    await Page.FillAsync("//input[@name='pinno']", pin);
    }
public async Task EnterMobnumber(string Mnumber)
    {
    await Page.FillAsync("//input[@name='telephoneno']", Mnumber);
    }
public async Task Enteremail(string emailid)
    {
    await Page.FillAsync("//input[@name='emailid']", emailid);
    }
public async Task EnterPword(string pword)
    {
    await Page.FillAsync("//input[@name='password']",pword);
    }
public async Task clickSubmiBtn()
    {
    await Page.ClickAsync("//input[@value='Submit']");
    }
public async Task PressTab()
    {
    await Page.Keyboard.PressAsync("Tab");
    }
}
