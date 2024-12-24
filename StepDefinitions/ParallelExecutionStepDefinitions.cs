using System;
using OpenQA.Selenium;
using SpecFlowProject.Hooks;
using TechTalk.SpecFlow;

namespace specflowNEW.StepDefinitions
{
    [Binding]
    [assembly: Parallelizable(ParallelScope.All)]

    public class ParallelExecutionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Hooks _hooks;

        public ParallelExecutionStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _hooks = new Hooks(_scenarioContext); // Instantiate Hooks
        }

        [Given(@"User is on the application page on (.*) browser")]
        public void GivenUserIsOnTheApplicationPageOnBrowser(string browserName)
        {
            _hooks.openBrowser(browserName.ToLower()); // Call openBrowser with the browser name
            var driver = _scenarioContext["WebDriver"] as IWebDriver;
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}



//using System;
//using SpecFlowProject.Hooks;
//using OpenQA.Selenium;
//using SpecFlowProject.Hooks;
//using TechTalk.SpecFlow;

//namespace specflowNEW.StepDefinitions
//{
//    [Binding]
//    [assembly: Parallelizable(ParallelScope.All)]

//    public class ParallelExecutionStepDefinitions
//    {
//        private ScenarioContext _scenarioContext;
//        private IWebDriver _driver;

//        public ParallelExecutionStepDefinitions(ScenarioContext scenarioContext)
//        {

//            _scenarioContext = scenarioContext;

//        }
//        [Given(@"User is on the application page on Edge browser")]
//        public void GivenUserIsOnTheApplicationPageOnEdgeBrowser()
//        {
//            //openBrowser("Edge");

//            _driver = _scenarioContext["WebDriver"] as IWebDriver;
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);
//        }

//        [Given(@"User is on the application page on Firefox browser")]
//        public void GivenUserIsOnTheApplicationPageOnFirefoxBrowser()
//        {
//            _driver = _scenarioContext["WebDriver"] as IWebDriver;
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);
//        }

//        [Given(@"User is on the application page on Chrome browser")]
//        public void GivenUserIsOnTheApplicationPageOnChromeBrowser()
//        {
//            _driver = _scenarioContext["WebDriver"] as IWebDriver;
//            _driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);
//        }
//    }
//}
