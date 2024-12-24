using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.Hooks
{
    [Binding]
    internal class Hooks
    {
        private ScenarioContext _scenarioContext;


        public Hooks(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;

        }

        public void openBrowser(string browserName)
        {
            if (browserName == "firefox")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                IWebDriver firefoxDriver = new FirefoxDriver();
                _scenarioContext["WebDriver"] = firefoxDriver;
            }
            else if (browserName == "edge")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                IWebDriver edgeDriver = new EdgeDriver();
                _scenarioContext["WebDriver"] = edgeDriver;
            }
            else if (browserName == "chrome")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                IWebDriver chromeDriver = new ChromeDriver();
                _scenarioContext["WebDriver"] = chromeDriver;
            }
        }
        [BeforeScenario]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            IWebDriver firefoxDriver = new FirefoxDriver();
            _scenarioContext["WebDriver"] = firefoxDriver;
            Console.WriteLine("Running before every scenario");
            
        }
        [AfterScenario]
        public void TearDown()
        {

            Console.WriteLine("Running after every scenario");
            var driver = _scenarioContext["WebDriver"] as IWebDriver;
            driver?.Quit();

        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            TestContext.Progress.WriteLine("Running before TestRun");

        }


        [AfterTestRun]
        public static void AfterTestRun()
        {


            TestContext.Progress.WriteLine("Running after TestRun");


        }


        [BeforeStep]
        public void BeforeStep()
        {

            Console.WriteLine("Running before step");

        }


        [AfterStep]
        public void AfterStep()
        {

            Console.WriteLine("Running after step");

        }
    }
}