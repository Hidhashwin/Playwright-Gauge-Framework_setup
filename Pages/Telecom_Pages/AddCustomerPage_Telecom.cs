using PlaywrightGaugeFramework.Utilities;
using System.Globalization;
using Microsoft.Playwright; 

    namespace PlaywrightGaugeFramework.Pages;

    public class AddCustomerPage_Telecom : BasePage
    {
    public async Task ClickAddCustomer()
    {
    await Page.GetByRole(AriaRole.Link, new() { Name = "Add Customer" }).ClickAsync();
    }
    public async Task SelectBackgroundCheckStatus(string status)
    {
    //await Page.GetByLabel(status).CheckAsync();
    await Page.GetByText(status, new() { Exact = true }).ClickAsync();
    }

    public async Task EnterFirstName(string firstName)
    {
    await Page.GetByRole(AriaRole.Textbox, new() { Name = "FirstName" }).FillAsync(firstName);
    }
     public async Task EnterLastName(string lastName)
    {
    await Page.GetByRole(AriaRole.Textbox, new() { Name = "LastName" }).FillAsync(lastName);
    }
     public async Task EnterEmail(string email)
    {
    await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).FillAsync(email);
    }
     public async Task EnterAddress(string address)
    {
    await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync(address);
    }
     public async Task EnterMobileNumber(string mobileNumber)
    {
    await Page.GetByPlaceholder("Mobile Number").FillAsync(mobileNumber);
    }
    public async Task ClickSubmitButton()
    {
    await Page.GetByRole(AriaRole.Button, new() { Name = "Submit" }).ClickAsync();
    }

    }