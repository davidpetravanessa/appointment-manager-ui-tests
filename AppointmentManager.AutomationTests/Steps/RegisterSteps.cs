using AppointmentManager.AutomationTests.Actions;
using AppointmentManager.AutomationTests.Helpers;
using AppointmentManager.AutomationTests.Pages;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AppointmentManager.AutomationTests.Steps
{
    [Binding]
    public class RegisterSteps
    {
        [Given(@"I Acces AppointmentManager apllication")]
        public void GivenIAccesAppointmentManagerApllication()
        {
            Navigation.NavigateTo();
            AppointmentManagerPages.HomePage.AllertCloseButton.Click();
        }

        [Then(@"I should be on home page")]
        public void ThenIShouldBeOnHomePage()
        {
            AppointmentManagerPages.HomePage.HomeButton.Exists().Should().BeTrue();
        }

    }
}
