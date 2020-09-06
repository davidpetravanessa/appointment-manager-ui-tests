using AppointmentManager.AutomationTests.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

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

        public static void DoubleClick(IWebElement element)
        {
            var actions = new OpenQA.Selenium.Interactions.Actions(WebDriver.Driver);
            actions.DoubleClick(element).Perform();
        }

        public static class TableExtensions
        {
            public static Dictionary<string, string> ToDictionary(Table table)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var row in table.Rows)
                {
                    dictionary.Add(row[0], row[1]);
                }
                return dictionary;
            }

        }
    }
}
