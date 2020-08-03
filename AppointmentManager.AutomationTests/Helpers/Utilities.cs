using AppointmentManager.AutomationTests.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentManager.AutomationTests.Helpers
{
    public static class Utilities
    {
        public static void SwitchToIframe(IWebElement iframe)
        {
            WebDriver.Driver.SwitchTo().DefaultContent();

            IWrapsElement wrapped = iframe as IWrapsElement;
            WebDriver.Driver.SwitchTo().Frame(wrapped.WrappedElement);
        }

        public static bool Exists(this IWebElement element)
        {
            try
            {
                return element.Enabled;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
