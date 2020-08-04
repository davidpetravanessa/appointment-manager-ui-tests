using AppointmentManager.AutomationTests.Helpers;
using AppointmentManager.AutomationTests.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AppointmentManager.AutomationTests.Steps
{
    [Binding]
   public class LogInSteps
    {
        [Given(@"I log in with user (.*) and (.*) crypted password")]
        public void GivenILogInWithUserTestTest_RoAndMLQLdJetoKXHGttMRACryptedPassword(string username, string password)
        {
            AppointmentManagerPages.HomePage.LogInPageButton.Click();
            Sync.ExplicitWait(1);
            AppointmentManagerPages.LogInPage.EmailLogInField.SendKeys(username);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.LogInPage.PasswordLogInField.SendKeys(AesEncryptionService.Decrypt(password));
            Sync.ExplicitWait(1);
            AppointmentManagerPages.LogInPage.SubmitLogInButton.Click();
        }

        [When(@"I am successfully logged in with (.*)")]
        [Then(@"I am successfully logged in with (.*)")]
        public void ThenIAmSuccessfullyLoggedInWith(string username)
        {
            AppointmentManagerPages.LogInPage.UserLabelAfterLogIn(username).Exists().Should().BeTrue();
        }

        [When(@"I tick (.*) option")]
        [Then(@"I tick (.*) option")]
        public void ThenITickLogOutOption(string option)
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.HomePage.CurrentUserDropDown.Click();
            Sync.ExplicitWait(1);
            Sync.FindElementWait(By.XPath($"//a[contains(@class,'dropdown-item') and text()='{option}']"));
            AppointmentManagerPages.HomePage.CurrentUserDropDownItem(option).Click();
        }

    }
}
