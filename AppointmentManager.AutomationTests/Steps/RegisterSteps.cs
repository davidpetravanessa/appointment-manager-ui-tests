using AppointmentManager.AutomationTests.Actions;
using AppointmentManager.AutomationTests.Helpers;
using AppointmentManager.AutomationTests.Pages;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AppointmentManager.AutomationTests.Steps
{
    [Binding]
    public class RegisterSteps
    {
        [Given(@"I Acces AppointmentManager apllication")]
        public void GivenIAccesAppointmentManagerApllication()
        {
            Navigation.NavigateTo();
            AppointmentManagerPages.HomePage.AllertCloseButton.Click();
        }

        [Then(@"I should be on home page")]
        public void ThenIShouldBeOnHomePage()
        {
            AppointmentManagerPages.HomePage.HomeButton.Exists().Should().BeTrue();
        }

        [Given(@"I create a new user with (.*) username and (.*) password")]
        public void GivenICreateANewUserWithUsernameAndPassword(string username, string password)
        {
            AppointmentManagerPages.HomePage.RegisterPageButton.Click();
            Sync.ExplicitWait(2);
            AppointmentManagerPages.RegisterPage.EmailRegisterField.SendKeys(username);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.RegisterPage.PasswordRegisterField.SendKeys(password);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.RegisterPage.RepeatPasswordRegisterField.SendKeys(password);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.RegisterPage.SubmitRegisterButton.Click();
        }

        [Then(@"I am on login page")]
        public void ThenIAmOnLoginPage()
        {
            AppointmentManagerPages.LogInPage.LogInLabel.Exists().Should().BeTrue();
        }

        [Then(@"I can't register in the application")]
        public void ThenICanTRegisterInTheApplication()
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.Common.ErrorLabel.Exists().Should().BeTrue();
        }

        [Then(@"The following error message should be displayed (.*)")]
        public void ThenTheFollowingErrorMessageShouldBeDisplayed(string errorMessage)
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.Common.ErrorMessage(errorMessage).Displayed.Should().BeTrue();
        }

    }
}
