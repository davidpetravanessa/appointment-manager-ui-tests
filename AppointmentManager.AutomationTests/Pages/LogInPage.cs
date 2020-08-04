using AppointmentManager.AutomationTests.Base;
using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentManager.AutomationTests.Pages
{
    public class LogInPage
    {
        public IWebElement LogInLabel => Sync.FindElementWait(By.XPath("//p[text()='Plaese log in to your account!']"));

        public IWebElement EmailLogInField => Sync.FindElementWait(By.Name("username"));

        public IWebElement PasswordLogInField => Sync.FindElementWait(By.Name("password"));

        public IWebElement SubmitLogInButton => Sync.FindElementWait(By.XPath("//button[text()='Log in']"));

        public IWebElement UserLabelAfterLogIn(string username)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//a[contains(@id,'currentUserDropdown') and text()='{username}']"));
        }
    }
}
