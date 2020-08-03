using AppointmentManager.AutomationTests.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AppointmentManager.AutomationTests.Helpers
{
    public class Sync
    {
        public static void ExplicitWait(int timeInSeconds)
        {
            try
            {
                new WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(timeInSeconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("dummyElement")));
            }
            catch (WebDriverTimeoutException) { }
        }
        public static IWebElement FindElementWait(By by)
        {
            var wait = new WebDriverWait(WebDriver.Driver, TimeSpan.FromSeconds(15));
            wait.IgnoreExceptionTypes(typeof(WebDriverException), typeof(ElementClickInterceptedException));
            wait.Until(drv => drv.FindElement(by).Displayed ? drv.FindElement(by) : null);

            return WebDriver.Driver.FindElement(by);
        }
    }
}