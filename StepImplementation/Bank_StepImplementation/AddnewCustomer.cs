using Gauge.CSharp.Lib.Attribute;
using PlaywrightGaugeFramework.Pages;
using PlaywrightGaugeFramework.Utilities;

namespace PlaywrightGaugeFramework.StepImplementation;

public class AddCustomerSteps
{
    private readonly AddCustomerPage _addCustomerPage = new();

[Step("Then user clicks new customer option")]
public async Task ClickNewCustomer()
    {
        try
        {
            await _addCustomerPage.ClickNewCustomer();
            
        }
        catch (Exception)
        {
            await ScreenshotHelper.CaptureScreenshot("NewCustomerClickFailed");
            throw;
        }
    }
[Step("Then the user enters customer name as <custname>")]
public async Task EnterCustomerName1(string custname)
    {
        try
        {
        await _addCustomerPage.EnterCustomerName(custname);
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("EnterCustomerNameFailed");
        throw;
        }
    }
[Step("Then the user selects gender as <genderselect>")]
public async Task selectgender(string genderselect)
    {
        try
        {
        await _addCustomerPage.SelectGender (genderselect);
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("SelectGenderFailed");
        throw;
        }
    }
[Step("Then the user enters DOB as <dob>")]
public async Task EnterDOB(string dob)
    {
        try
        {
        await _addCustomerPage.EnterDOB(dob);
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("EnterDOBFailed");
        throw;
        }
    }
[Step("Then the user enters address as <address>")]
public async Task EnterAddress(string address)
    {
        try
        {
        await _addCustomerPage.EnterAddress(address);
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("EnterAddressFailed");
        throw;
        }
    }    
[Step("Then the user enters city as <city>")]
public async Task EnterCity(string city)
    {
        try
        {
        await _addCustomerPage.EnterCity(city);
        Logger.Pass($"City entered successfully : {city}");
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("EntercitysFailed");
        throw;
        }
    }
[Step("Then the user enters state as <state>")]
public async Task EnterState(string state)
    {
        try
        {
        await _addCustomerPage.EnterState(state);
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("EnterstateFailed");
        throw;
        }
    }
[Step("Then the user enters PIN number as <pin>")]
public async Task EnterPin(string pin)
    {
        try
        {
        await _addCustomerPage.EnterPin(pin);
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("EnterpinFailed");
        throw;
        }
    }
[Step("Then the user enters Telephone Number as <Mnumber>")]
public async Task EnterMobnumber(string Mnumber)
    {
        try
        {
        await _addCustomerPage.EnterMobnumber(Mnumber);
        //await _addCustomerPage.PressTab();
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("EnterMobnumberfailed");
        throw;
        }
    }
[Step("Then the user enters email address as <emailid>")]
public async Task Enteremail(string emailid)
    {
        try
        {
        await _addCustomerPage.Enteremail(emailid);
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("Enteremailfailed");
        throw;
        }
    }
[Step("Then the user enters the password as <pword>")]
public async Task EnterPword(string pword)
    {
        try
        {
        await _addCustomerPage.EnterPword(pword);
        }
        catch (Exception)
        {
        await ScreenshotHelper.CaptureScreenshot("Enterpasswordfailed");
        throw;
        }
    }
[Step("Then the user clicks sumit button")]
public async Task clickSubmiBtn()
    {
        try
        {
            await _addCustomerPage.clickSubmiBtn();
            
        }
        catch (Exception)
        {
            await ScreenshotHelper.CaptureScreenshot("clickSubmiBtnfailed");
            throw;
        }
    }
}
