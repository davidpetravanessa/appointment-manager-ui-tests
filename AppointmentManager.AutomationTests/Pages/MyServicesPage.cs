using AppointmentManager.AutomationTests.Base;
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

        public IWebElement SecondServiceNameInList => Sync.FindElementWait(By.XPath("//tbody/tr[2]/td[2]"));

        public IWebElement AppointmentStatusFirstRow => Sync.FindElementWait(By.XPath("//tbody//tr[1]//td[4][normalize-space()]"));

        public IWebElement SetToDoneButton => Sync.FindElementWait(By.XPath("//button[text()='Set to Done']"));
        
        public IWebElement DeteleButtonMyServices => Sync.FindElementWait(By.XPath("//button[text()='Delete']"));

        public IWebElement DeteleButtonSecondRow => Sync.FindElementWait(By.XPath("(//button[text()='Delete'])[2]"));
       

        public IWebElement ConfirmOrDeclineAppointment(string option)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//tbody//tr[1]//td[5]//button[text()='{option}']"));
        }

        public IWebElement ButtonsFromSecondRowService(string option)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//tr[2]//a[text()='{option}']"));
        }
        public IWebElement ServiceNameSecondRow(string name)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//tr[2]//td[text()='{name}']"));
        }
    }
}
