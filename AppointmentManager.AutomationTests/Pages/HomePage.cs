using AppointmentManager.AutomationTests.Base;
using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;

namespace AppointmentManager.AutomationTests.Pages
{
    public class HomePage
    {
        public IWebElement RegisterPageButton => Sync.FindElementWait(By.XPath("//a[contains(@class,'nav-link') and text()='Register']"));

        public IWebElement LogInPageButton => Sync.FindElementWait(By.XPath("//a[contains(@class,'nav-link') and text()='Log in']"));

        public IWebElement HomeButton => Sync.FindElementWait(By.XPath("//a[contains(@class,'navbar-brand') and text()='Home']"));

        public IWebElement UsersPageButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='Users']"));

        public IWebElement MyServicesPageButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='My Services']"));

        public IWebElement ClientsPageButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='Clients']"));

        public IWebElement MyAppointmentsPageButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='My Appointments']"));

        public IWebElement AboutPageButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='About']"));

        public IWebElement AllertCloseButton => Sync.FindElementWait(By.XPath("//a[@class='close']"));

        public IWebElement UsersMyServiceClientsMyAppointmentsAboutPAGES(string pageName)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//li[@class='nav-item']/a[normalize-space()='{pageName}']"));
        }
    }
}