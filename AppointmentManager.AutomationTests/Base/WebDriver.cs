using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.IO;
using AppointmentManager.AutomationTests.Helpers;

namespace AppointmentManager.AutomationTests.Base
{
    public class WebDriver
    {
        private static IWebDriver _webDriver;
        public static IWebDriver Driver
        {
            get
            {
                if (_webDriver == null)
                {
                    _webDriver = GetWebDriver();
                }
                return _webDriver;
            }
        }

        public static void Quit()
        {
            _webDriver?.Close();
            _webDriver?.Quit();

            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
            _webDriver = null;
        }

        private static IWebDriver GetWebDriver()
        {
            switch (AppSettings.BrowserType)
            {
                case BrowserType.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    return new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, chromeOptions, TimeSpan.FromSeconds(180));
                case BrowserType _browserType: throw new NotSupportedException($"{_browserType} is not a supported browser");
                default: throw new NotSupportedException("not supported browser: <null>");
            }
        }
    }
}