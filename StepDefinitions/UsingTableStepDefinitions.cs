using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace specflowNEW.StepDefinitions
{
    [Binding]
    public class UsingTableStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public UsingTableStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"User is on the Rahul Shetty angular practice page")]
        public void GivenUserIsOnTheRahulShettyAngularPracticePage()
        {
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters all information")]
        public void WhenUserEntersAllInformation(Table table)
        {
            IWebElement usrname = _driver.FindElement(By.XPath("//div[@class='form-group']//input[@name='name']"));
            IWebElement email = _driver.FindElement(By.XPath("//input[@name='email']"));
            IWebElement password = _driver.FindElement(By.XPath("//input[@id='exampleInputPassword1']"));
            IWebElement chckbx = _driver.FindElement(By.XPath("//input[@id='exampleCheck1']"));
            IWebElement gender = _driver.FindElement(By.XPath("//select[@id='exampleFormControlSelect1']"));
            //IWebElement radio = _driver.FindElement(By.XPath("//label[normalize-space()='Employment Status:']"));
            IWebElement dob = _driver.FindElement(By.XPath("//input[@name='bday']"));

            foreach (var row in table.Rows)
            {
                String usrnameStr = row["Name"];
                String emailStr = row["Email"];
                String passwordStr = row["Password"];
                String icecreamsStr = row["LoveIcecreams"];
                String genderStr = row["Gender"];
                String employmentStr = row["Employment"];
                String DOBStr = row["DateOfBirth"];
                Thread.Sleep(2000);
                usrname.SendKeys(usrnameStr);
                Thread.Sleep(2000);
                email.SendKeys(emailStr);
                Thread.Sleep(2000);
                password.SendKeys(passwordStr);
                Thread.Sleep(2000);
                if (chckbx.Selected)
                {
                    if (icecreamsStr == "No")
                    {
                        chckbx.Click();
                    }
                }
                if (icecreamsStr == "Yes")
                {
                    chckbx.Click();
                }
                gender.Click();

                var select = new SelectElement(gender);
                Thread.Sleep(2000);
                //select by value
                select.SelectByText(genderStr);
                Thread.Sleep(2000);
                if (employmentStr.Equals("Employed", StringComparison.OrdinalIgnoreCase))
                {
                    _driver.FindElement(By.XPath("//label[normalize-space()='Employed']")).Click();
                }
                else if (employmentStr.Equals("Student", StringComparison.OrdinalIgnoreCase))
                {
                    _driver.FindElement(By.XPath("//label[normalize-space()='Student']")).Click();
                }
                Thread.Sleep(1000);
                dob.Click();
                dob.Click();
                dob.SendKeys(DOBStr);
                IWebElement submit = _driver.FindElement(By.XPath("//input[@value='Submit']"));
                submit.Click();
                Thread.Sleep(1000);


            }

        }

        [When(@"User clicks on Submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            Console.WriteLine("Clicked");
        }

        [Then(@"form gets submitted")]
        public void ThenFormGetsSubmitted()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Form Submitted");
        }
    }
}
