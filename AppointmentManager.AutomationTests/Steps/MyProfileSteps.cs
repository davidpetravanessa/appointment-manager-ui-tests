using AppointmentManager.AutomationTests.Helpers;
using AppointmentManager.AutomationTests.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TechTalk.SpecFlow;
using static AppointmentManager.AutomationTests.Helpers.Utilities;

namespace AppointmentManager.AutomationTests.Steps
{
    [Binding]
    public class MyProfileSteps
    {

        [Then(@"I can edit the user profile")]
        public void ThenICanEditTheUserProfile(Table editProfileTable)
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyProfilePage.EditProfileButton.Click();
            Sync.ExplicitWait(1);

            var dictionary = TableExtensions.ToDictionary(editProfileTable);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyProfilePage.FirstNameField.SendKeys(dictionary["FirstName"]);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyProfilePage.LastNameField.SendKeys(dictionary["LastName"]);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyProfilePage.PhoneField.SendKeys(dictionary["Phone"]);

            Sync.ExplicitWait(2);
            AppointmentManagerPages.MyProfilePage.UpdateInfoButton.Click();
        }

    }
}
