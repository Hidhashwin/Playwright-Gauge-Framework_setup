using Gauge.CSharp.Lib.Attribute;
using PlaywrightGaugeFramework.Pages;
using PlaywrightGaugeFramework.Utilities;

namespace PlaywrightGaugeFramework.StepImplementation;

public class AddCustomerStepsTelecom
{
    private readonly AddCustomerPage_Telecom _addCustomerPage_Telecom = new();

    [Step("Open Guru99 Telecom application")]
    public async Task OpenGuru99Telecom()
    {
    await _addCustomerPage_Telecom.NavigateToApplication("Guru99Telecom");
    }
    [Step("When user clicks Add Customer option in the home page")]
    public async Task ClickAddCustomer()
    {
    await _addCustomerPage_Telecom.ClickAddCustomer();
    }
    [Step("When user checks <status> radio button for Background Check")]
    public async Task SelectBackgroundCheckStatus(string status)
    {
    await _addCustomerPage_Telecom.SelectBackgroundCheckStatus(status);
    }
    [Step("When user enters the First name as <firstName> in Billing address")]
    public async Task EnterFirstName(string firstName)
    {
    await _addCustomerPage_Telecom.EnterFirstName(firstName);
    }
    [Step("When user enters the Last name as <lastName> in Billing address")]
    public async Task EnterLastName(string lastName)
    {
    await _addCustomerPage_Telecom.EnterLastName(lastName);
    }
    [Step("When user enters the Email as <email> in Billing address")]
    public async Task EnterEmail(string email)
    {
    await _addCustomerPage_Telecom.EnterEmail(email);
    }
    [Step("When user enters the Address as <address> in Billing address")]
    public async Task EnterAddress(string address)
    {
    await _addCustomerPage_Telecom.EnterAddress(address);
    }
    [Step("When user enters the Mobile Number as <mobileNumber> in Billing address")]
    public async Task EnterMobileNumber(string mobileNumber)
    {
    await _addCustomerPage_Telecom.EnterMobileNumber(mobileNumber);
    }
    [Step("When user clicks Submit button")]
    public async Task ClickSubmitButton()
    {
    await _addCustomerPage_Telecom.ClickSubmitButton();
    }
}