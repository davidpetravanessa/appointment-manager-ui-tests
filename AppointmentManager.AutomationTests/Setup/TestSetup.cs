using AppointmentManager.AutomationTests.Actions;
using AppointmentManager.AutomationTests.Base;
using AppointmentManager.AutomationTests.Helpers;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using Dapper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace AppointmentManager.AutomationTests.Setup
{
    [Binding]
    public class TestSetup
    {

        private readonly ScenarioContext scenarioContext;
        private readonly IObjectContainer objectContainer;
        private static ExtentTest _featureName;
        private static ExtentTest _scenario;
        private static AventStack.ExtentReports.ExtentReports _extent;

        private static string _reportingPath = Path.Combine(Environment.CurrentDirectory + "\\TestReports");
        private static string _screenshotsPath = Path.Combine(_reportingPath + "\\Screenshots");
        public TestSetup(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            this.objectContainer = objectContainer;
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void MaximizeWindow()
        {
            Browser.MaximizeWindow();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Quit();
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            _extent = new AventStack.ExtentReports.ExtentReports();
            var htmlReporter = new ExtentV3HtmlReporter($"{_reportingPath}\\BTAMReport {DateTime.Now.ToString("dd-MMM-yyyy hh.mm.ss")}.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            _extent.AttachReporter(htmlReporter);

            Directory.CreateDirectory(_screenshotsPath);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            _featureName = _extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void SaveReport()
        {
            _extent.Flush();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _scenario = _featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            objectContainer.RegisterInstanceAs(WebDriver.Driver);
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    _scenario.CreateNode<Given>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    _scenario.CreateNode<When>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    _scenario.CreateNode<Then>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    _scenario.CreateNode<And>(scenarioContext.StepContext.StepInfo.Text);
            }
            else if (scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                {
                    _scenario
                        .CreateNode<Given>(scenarioContext.StepContext.StepInfo.Text)
                        .Fail(scenarioContext.TestError.Message)
                        .AddScreenCaptureFromPath(TakeScreenshot());
                }
                else if (stepType == "When")
                    _scenario
                        .CreateNode<When>(scenarioContext.StepContext.StepInfo.Text)
                        .Fail(scenarioContext.TestError.Message)
                        .AddScreenCaptureFromPath(TakeScreenshot());
                else if (stepType == "Then")
                {
                    _scenario
                        .CreateNode<Then>(scenarioContext.StepContext.StepInfo.Text)
                        .Fail(scenarioContext.TestError.Message)
                        .AddScreenCaptureFromPath(TakeScreenshot());
                }
            }
        }
        public string TakeScreenshot()
        {
            var title = scenarioContext.ScenarioInfo.Title;
            var fileName = $@"{_screenshotsPath}\{title + " - " + DateTime.Now.ToString("dd-MMM-yyyy hh.mm.ss")}.png";
            Screenshot file = ((ITakesScreenshot)WebDriver.Driver).GetScreenshot();
            file.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            return fileName;
        }
    }
}