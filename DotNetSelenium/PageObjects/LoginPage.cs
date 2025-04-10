using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using DotNetSelenium.Utilities;
using Newtonsoft.Json.Linq;

namespace DotNetSelenium.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        // Write the required locators here

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void PerformLogin()
        {
            // write your logic here
        }

/**
 * @Test15
 * @description : Clicks the logout option from the Admin dropdown and verifies if the user is redirected to the login page.
 *
 * Steps:
 * 1. Clicks on the Admin dropdown menu.
 * 2. Selects the "Logout" option to initiate logout.
 * 3. Waits for the login page to appear by checking the presence of the login button.
 * 4. Logs the result and handles any exceptions that occur during the process.
 *
 * @returns : True if the login button is displayed, indicating successful logout; otherwise, throws an exception.
 */
        public bool VerifyLogoutFunctionality()
        {
            // write your logic here
            return false;
        }
    }
}
