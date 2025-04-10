using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;
using DotNetSelenium.Utilities;

namespace DotNetSelenium.PageObjects
{
    public class DoctorPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private JObject testData;

        public DoctorPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        // Write all the required Locators here

        /**
        * @Test3
        * @description Searches for a specific patient in the In-Patient list and verifies that their overview page is displayed.
        *
        * Steps:
        * 1. Reads the patient name from a JSON test data file.
        * 2. Clicks on the Doctor module and navigates to the In-Patient tab.
        * 3. Locates the appropriate search box and enters the patient name.
        * 4. Waits briefly and clicks the preview icon from the Actions column.
        * 5. Retrieves and returns the patient name heading from the overview page for validation.
        *
        * @returns The patient name displayed on the overview page, converted to lowercase and trimmed.
        */
        public String VerifyPatientOverview()
        {
            //Write your logic here
            return " ";
        }

        /**
        * @Test4
        * @description
        * Adds a "Progress Note" for a specified patient from the In-Patient list and verifies the success message.
        *
        * Steps:
        * 1. Reads the patient name from the JSON test data file.
        * 2. Navigates to the Doctor module and selects the In-Patient tab.
        * 3. Searches for the patient by name and opens their preview page.
        * 4. Navigates to the Notes section and clicks the Add Notes button.
        * 5. Selects "Progress Note" as the note type and template.
        * 6. Enters a sample subjective note in the input field.
        * 7. Saves the note and verifies the success confirmation message.
        *
        * @returns The text of the success confirmation popup after saving the note.
        */
        public String AddProgressNoteForPatient()
        {
            // Write your logic here
            return " ";
        }
    }
}
