using DotNetSelenium.Utilities;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace DotNetSelenium.PageObjects
{
    public class ADTPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ADTPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

       //Writer the required locators here
        
        /**
            * @Test14
            * Attempts to update a patient's doctor without selecting one and verifies that the appropriate validation message is shown.
            *
            * Steps:
            * 1. Reads a test patient name from a JSON file.
            * 2. Navigates to the ADT section and selects the first available counter item.
            * 3. Opens the "Admitted Patients" tab and searches for the patient.
            * 4. Opens the "Change Doctor" modal using the More Options ("...") button.
            * 5. Clicks the "Update" button without selecting a doctor from the list.
            * 6. Verifies that the error message "Select doctor from the list." is displayed.
            *
            * @returns True if the error message is displayed; otherwise, throws an exception.
        */
        public bool VerifyFieldLevelErrorMessage()
        {
            
            return false;
        }
    }

}
