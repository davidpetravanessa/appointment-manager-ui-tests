using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;

namespace AppointmentManager.AutomationTests.Pages
{
    public class MyProfilePage
    {
        public IWebElement EditProfileButton => Sync.FindElementWait(By.XPath("//a[normalize-space()='Edit profile']"));
        public IWebElement FirstNameField => Sync.FindElementWait(By.Name("firstName"));
        public IWebElement LastNameField => Sync.FindElementWait(By.Name("lastName"));
        public IWebElement PhoneField => Sync.FindElementWait(By.Name("phone"));
        public IWebElement UpdateInfoButton => Sync.FindElementWait(By.XPath("//button[text()='Update info']"));
    }
}
