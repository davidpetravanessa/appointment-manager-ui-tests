using AppointmentManager.AutomationTests.Helpers;
using AppointmentManager.AutomationTests.Pages;
using FluentAssertions;
using Microsoft.VisualBasic;
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

        [When(@"The (.*) service should be successfully created")]
        [Then(@"The (.*) service should be successfully created")]
        public void ThenTheServiceShouldBeSuccessfullyCreated(string serviceName)
        {
            AppointmentManagerPages.MyServicesPage.SecondServiceNameInList.Text.Should().Be(serviceName);
        }

        [Given(@"I make an appointment to a service")]
        [Then(@"I make an appointment to a service")]
        public void GivenIMakeAnAppointmentToAService()
        {
            Sync.ExplicitWait(1);
            Sync.FindElementWait(By.XPath("(//tbody/tr/td[4])[1]"));
            AppointmentManagerPages.ServicesPage.DetailButtonFirstService.Click();
            Sync.ExplicitWait(1);
            Utilities.DoubleClick(AppointmentManagerPages.ServicesPage.CreateAppointmentButton);
            Sync.ExplicitWait(1);
            AppointmentManagerPages.ServicesPage.AppointmentDateField.SendKeys("12 December, 2020 17:00");
            Sync.ExplicitWait(1);
            AppointmentManagerPages.ServicesPage.NewAppointmentLabel.Click();
            Sync.ExplicitWait(1);
            Sync.FindElementWait(By.XPath("//button[text()='Save']"));
            AppointmentManagerPages.MyServicesPage.SaveButton.Click();
        }

        [When(@"I tick a user")]
        public void WhenITickUser()
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.ServicesPage.MailLinkSecondRow.Click();
        }

        [Then(@"I can't edit others user profile")]
        public void ThenICanTEditOthersUserProfile()
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyProfilePage.EditProfileButton.Displayed.Should().BeFalse();
        }

        [When(@"I can (.*) an appointment")]
        [Then(@"I can (.*) an appointment")]
        public void ThenICanAnAppointment(string option)
        {
            if (option == "Set to Done")
            {
                Sync.ExplicitWait(2);
                AppointmentManagerPages.MyServicesPage.SetToDoneButton.Click();
            }
            else
            {
                Sync.ExplicitWait(1);
                AppointmentManagerPages.Common.DetailsButton.Click();
                Sync.ExplicitWait(1);
                AppointmentManagerPages.MyServicesPage.ConfirmOrDeclineAppointment(option).Click();
            }
        }

        [When(@"The apoointment state should be updated to (.*)")]
        [Then(@"The apoointment state should be updated to (.*)")]
        public void ThenTheApoointmentStateShouldBeUpdatedTo(string status)
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.AppointmentStatusFirstRow.Text.Should().Be(status);
        }

        [When(@"I choose the (.*) option from the desired service")]
        [Then(@"I choose the (.*) option from the desired service")]
        public void ThenIChooseTheDetailsOptionFromTheDesiredService(string button)
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.ButtonsFromSecondRowService(button).Click();
        }

        [Then(@"I can edit the service")]
        public void ThenICanEditTheService()
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.ServiceNameField.Clear();
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.ServiceNameField.SendKeys("Livrari");
            AppointmentManagerPages.Common.SaveButton.Click();
        }

        [Then(@"The the new service name (.*) exist")]
        public void ThenTheTheNewServiceNameServiceTestExist(string name)
        {
            Sync.ExplicitWait(1);
            AppointmentManagerPages.MyServicesPage.ServiceNameSecondRow(name).Exists().Should().BeTrue();
        }

        [Then(@"I (.*) the created service")]
        public void ThenIDeleteTheCreatedService(string button)
        {
            Sync.ExplicitWait(1);

            if (button == "Delete")
            {
                AppointmentManagerPages.MyServicesPage.DeteleButtonMyServices.Click();
            }
            else
            {
                AppointmentManagerPages.MyServicesPage.ButtonsFromSecondRowService(button).Click();
            }
        }

        [Then(@"I (.*) the new created service")]
        public void ThenIDeleteTheNewCreatedService(string button)
        {
            Sync.ExplicitWait(2);
            AppointmentManagerPages.MyServicesPage.DeteleButtonSecondRow.Click();
            Sync.ExplicitWait(1);
        }

    }
}
