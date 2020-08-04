using AppointmentManager.AutomationTests.Helpers;
using AppointmentManager.AutomationTests.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace AppointmentManager.AutomationTests.Steps
{
    [Binding]
    public class ServicesSteps
    {
        [When(@"I create a service with the name (.*)")]
        public void WhenICreateAServiceWithTheName(string serviceName)
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.CreateANewServiceButton.Click();
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.ServiceNameField.Click();
            AppointmentManagerPages.MyServicesPage.ServiceNameField.SendKeys(serviceName);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.SaveButton.Click();
        }

        [Then(@"The (.*) service should be successfully created")]
        public void ThenTheServiceShouldBeSuccessfullyCreated(string serviceName)
        {
            AppointmentManagerPages.MyServicesPage.FirstServiceNameInList.Text.Should().Be(serviceName);
        }

        [Given(@"I make an appointment to a service")]
        public void GivenIMakeAnAppointmentToAService()
        {
            Sync.ExplicitWait(1);
            Sync.FindElementWait(By.XPath("(//tbody/tr/td[4])[1]"));
            AppointmentManagerPages.ServicesPage.DetailButtonFirstService.Click();
            Sync.ExplicitWait(1);
            //AppointmentManagerPages.ServicesPage.CreateAppointmentButton.Click();
            Utilities.DoubleClick(AppointmentManagerPages.ServicesPage.CreateAppointmentButton);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.ServicesPage.AppointmentDateField.SendKeys("12/12/2021");
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.SaveButton.Click();
        }

    }
}
