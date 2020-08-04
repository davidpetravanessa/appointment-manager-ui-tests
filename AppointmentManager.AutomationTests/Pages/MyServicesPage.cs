using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentManager.AutomationTests.Pages
{
    public class MyServicesPage
    {
        public IWebElement CreateANewServiceButton => Sync.FindElementWait(By.XPath("//a[normalize-space()='Create a new service']"));

        public IWebElement ServiceNameField => Sync.FindElementWait(By.Name("name"));

        public IWebElement SaveButton => Sync.FindElementWait(By.XPath("//button[text()='Save']"));

        public IWebElement FirstServiceNameInList => Sync.FindElementWait(By.XPath("//tbody/tr/td[2]"));
       
    }
}
