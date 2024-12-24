using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace specflowNEW.StepDefinitions
{
    [Binding]

    public class TestLoginFunctionalityWithParametersStepDefinitions
    {
        //private ScenarioContext _scenarioContext;
        //private IWebDriver _driver;

        //public TestLoginFunctionalityWithParametersStepDefinitions(ScenarioContext scenarioContext)
        //{

        //    _scenarioContext = scenarioContext;
        //    _driver = _scenarioContext["WebDriver"] as IWebDriver;
        //    _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        //    _driver.Manage().Window.Maximize();
        //    Thread.Sleep(2000);

        //}

        

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersTheAnd(string usrname, string passwd)
        {
            Console.WriteLine($"The username is {usrname} and password is {passwd}");
        }

        [When(@"User Clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            //IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));

            //loginbutton.Click();

            //Thread.Sleep(1000);
            Console.WriteLine("Login button clicked");
        }

        [Then(@"User selects city and country information")]
        public void ThenUserSelectsCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows) 
            {
                String city = row["city"];
                String country = row["country"];
                Console.WriteLine(city+" "+country);
            }
        }
    }
}
