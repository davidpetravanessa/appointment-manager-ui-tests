using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;

namespace AppointmentManager.AutomationTests.Pages
{
    public class RegisterPage
    {
        public IWebElement EmailRegisterField => Sync.FindElementWait(By.Name("email"));

        public IWebElement PasswordRegisterButton => Sync.FindElementWait(By.Name("password"));

        public IWebElement RepeatPasswordRegisterButton => Sync.FindElementWait(By.Name("repeat the password"));

        public IWebElement SubmitRegisterButton => Sync.FindElementWait(By.XPath("//button[text()='Register']"));
    }
}