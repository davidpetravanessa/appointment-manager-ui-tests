using AppointmentManager.AutomationTests.Helpers;
using OpenQA.Selenium;

namespace AppointmentManager.AutomationTests.Pages
{
    public class RegisterPage
    {
        public IWebElement EmailRegisterField => Sync.FindElementWait(By.Name("email"));

        public IWebElement PasswordRegisterField => Sync.FindElementWait(By.Name("password"));

        public IWebElement RepeatPasswordRegisterField => Sync.FindElementWait(By.Name("passwordConfirm"));

        public IWebElement SubmitRegisterButton => Sync.FindElementWait(By.XPath("//button[text()='Register']"));
    }
}