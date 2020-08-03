using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;

namespace AppointmentManager.AutomationTests.Pages
{
    public class HomePage
    {
        public IWebElement RegisterPageButton => Sync.FindElementWait(By.XPath("//a[contains(@class,'nav-link') and text()='Register']"));

        public IWebElement LogInButton => Sync.FindElementWait(By.XPath("//a[contains(@class,'nav-link') and text()='Log in']"));

        public IWebElement HomeButton => Sync.FindElementWait(By.XPath("//a[contains(@class,'navbar-brand') and text()='Home']"));

        public IWebElement UsersButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='Users']"));

        public IWebElement MyServicesButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='Users']"));

        public IWebElement ClientsButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='Clients']"));

        public IWebElement MyAppointmentsButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='My Appointments']"));

        public IWebElement AboutButton => Sync.FindElementWait(By.XPath("//li[@class='nav-item']/a[normalize-space()='About']"));

        public IWebElement AllertCloseButton => Sync.FindElementWait(By.XPath("//a[@class='close']"));
    }
}