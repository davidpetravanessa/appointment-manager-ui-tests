using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentManager.AutomationTests.Pages
{
    public class ServicesPage
    {
        public IWebElement DetailButtonFirstService => Sync.FindElementWait(By.XPath("(//tbody/tr/td[4]//a)[1]"));
        public IWebElement AppointmentDateField => Sync.FindElementWait(By.Name("date"));
        public IWebElement CreateAppointmentButton => Sync.FindElementWait(By.XPath("//a[contains(@class,'btn btn-primary') and normalize-space()='Create appointment']"));

        public IWebElement MailLinkSecondRow => Sync.FindElementWait(By.XPath("//tbody//tr[2]//td[3]//a"));
        public IWebElement NewAppointmentLabel => Sync.FindElementWait(By.XPath("//h3[text()='Create a new appointment']"));
        
    }
}
