using AppointmentManager.AutomationTests.Helpers;
using AppointmentManager.AutomationTests.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AppointmentManager.AutomationTests.Steps
{
    [Binding]
    public class CommonSteps
    {
        [When(@"I access (.*) page")]
        [Given(@"I access (.*) page")]
        public void GivenIAccesMyServicesPage(string pageName)
        {
            Sync.ExplicitWait(2);
            AppointmentManagerPages.HomePage.UsersMyServiceClientsMyAppointmentsAboutPAGES(pageName).Click();
        }

    }
}
