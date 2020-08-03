﻿using AppointmentManager.AutomationTests.Base;
using SeleniumExtras.PageObjects;

namespace AppointmentManager.AutomationTests.Pages
{
    public class AppointmentManagerPages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriver.Driver, page);
            return page;
        }

        public static HomePage HomePage => GetPage<HomePage>();
        public static RegisterPage RegisterPage => GetPage<RegisterPage>();
    }
}
