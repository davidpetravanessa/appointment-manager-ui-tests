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
        [Given(@"I log in with user (.*) and (.*) password")]
        [When(@"I log in with user (.*) and (.*) password")]
        [Then(@"I log in with user (.*) and (.*) password")]
        public void GivenILogInWithUserTestTest_RoAndMLQLdJetoKXHGttMRACryptedPassword(string username, string password)
        {
            Sync.ExplicitWait(2);
            AppointmentManagerPages.HomePage.LogInPageButton.Click();
            Sync.ExplicitWait(1);
            AppointmentManagerPages.LogInPage.EmailLogInField.SendKeys(username);
            Sync.ExplicitWait(2);
            AppointmentManagerPages.LogInPage.PasswordLogInField.SendKeys(password);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.LogInPage.SubmitLogInButton.Click();
        }

        [When(@"I am successfully logged in with (.*)")]
        [Then(@"I am successfully logged in with (.*)")]
        public void ThenIAmSuccessfullyLoggedInWith(string username)
        {
            Sync.ExplicitWait(2);
            AppointmentManagerPages.LogInPage.UserLabelAfterLogIn(username).Exists().Should().BeTrue();
        }

        [Given(@"I tick (.*) option")]
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

        [Then(@"The log in failed with (.*)")]
        public void ThenTheLogInFailedWith(string username)
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.LogInPage.LogInTag.Displayed.Should().BeTrue();
        }

        
    }
}
