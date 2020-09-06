using AppointmentManager.AutomationTests.Base;
using System;
using System.Configuration;

namespace AppointmentManager.AutomationTests.Helpers
{
    public class AppSettings
    {
        private static Configuration _configuration => ConfigurationManager.OpenExeConfiguration(@"AppointmentManager.AutomationTests.dll");
        public static BrowserType BrowserType => (BrowserType)Enum.Parse(typeof(BrowserType), _configuration.AppSettings.Settings["BrowserType"].Value);
        public static string BaseUrl => _configuration.AppSettings.Settings["BaseUrl"].Value;
        public static string UserName => AesEncryptionService.Decrypt(_configuration.AppSettings.Settings["UserName"].Value);
        public static string Password => AesEncryptionService.Decrypt(_configuration.AppSettings.Settings["Password"].Value);

    }
}
