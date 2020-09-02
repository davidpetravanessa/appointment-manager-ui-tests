using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentManager.AutomationTests.Pages
{
    public class Common
    {
        public IWebElement DetailsButton => Sync.FindElementWait(By.XPath("//a[text()='Details']"));

        public IWebElement EditButton => Sync.FindElementWait(By.XPath("//a[text()='Edit']"));

        public IWebElement SaveButton => Sync.FindElementWait(By.XPath("//button[text()='Save']"));

        public IWebElement ErrorLabel => Sync.FindElementWait(By.XPath("//h1[text()='Whitelabel Error Page']"));

    }
}
