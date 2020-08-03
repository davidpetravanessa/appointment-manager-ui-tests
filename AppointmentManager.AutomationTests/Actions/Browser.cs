using AppointmentManager.AutomationTests.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentManager.AutomationTests.Actions
{
    public class Browser
    {
        public static void NavigateTo(string url)
        {
            WebDriver.Driver.Navigate().GoToUrl(url);
        }

        public static void MaximizeWindow()
        {
            WebDriver.Driver.Manage().Window.Maximize();
        }

        public static void Quit()
        {
            WebDriver.Quit();
        }
    }
}