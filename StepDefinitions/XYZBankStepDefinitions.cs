using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace specflowNEW.StepDefinitions
{
    [Binding]
    public class XYZBankStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XYZBankStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"Customer is on login page")]
        public void GivenCustomerIsOnLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        

        [When(@"Customer clicks on Customer Login button")]
        public void WhenCustomerClicksOnButton()
        {
            IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
            CustLogin.Click();
            Thread.Sleep(2000);
        }

        [When(@"selects the name")]
        public void WhenSelectsTheName()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));
            NamesDropDown.Click();
            var select = new SelectElement(NamesDropDown);
            Thread.Sleep(2000);
            //select by value
            select.SelectByText("Harry Potter");
            Thread.Sleep(2000);
        }

        //[When(@"selects the name")]
        //public void WhenSelectsTheName(Table table)
        //{
        //    throw new PendingStepException();
        //}

        [When(@"User Clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            NamesDropDown.Click();
        }

        [Then(@"User is logged in and can see data")]
        public void ThenUserIsLoggedInAndCanSeeData()
        {
            Console.WriteLine("Customer Logged In");
        }
        

        [Given(@"Manager is on login page")]
        public void GivenManagerIsOnLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"Customer clicks on Bank Manager Login button")]
        public void WhenCustomerClicksOnBankManagerLoginButton()
        {
            IWebElement manLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));
            manLogin.Click();
            Thread.Sleep(2000);
        }

        [When(@"Clicks on Add Customer Button")]
        public void WhenClicksOnAddCustomerButton()
        {
            //IWebElement manLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));
            //manLogin.Click();
            IWebElement add = _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']"));
            add.Click();
            Thread.Sleep(2000);

        }

        [When(@"enters firstname, lastname, postalcode")]
        public void WhenEntersFirstnameLastnamePostalcode(Table table)
        {
            IWebElement fname = _driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
            IWebElement lname = _driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));
            IWebElement post = _driver.FindElement(By.XPath("//input[@placeholder='Post Code']"));
            //fname.SendKeys("Shravya2");
            //Thread.Sleep(2000);
            //lname.SendKeys("Karanth2");
            //Thread.Sleep(2000);
            //post.SendKeys("575005");
            //Thread.Sleep(2000);
            foreach (var item in table.Rows)
            {
                fname.SendKeys(item["firstname"]);
                Thread.Sleep(2000);
                lname.SendKeys(item["lastname"]);
                Thread.Sleep(2000);
                post.SendKeys(item["postalcode"]);
                Thread.Sleep(2000);
                IWebElement button = _driver.FindElement(By.XPath("//button[@type='submit']"));
                button.Click();
                Thread.Sleep(2000);
            }
        }

        [When(@"clicks on Add new Customer Button")]
        public void WhenClicksOnAddNewCustomerButton()
        {
            Console.WriteLine("users added");
        }

        [Then(@"new Customer is added")]
        public void ThenNewCustomerIsAdded()
        {
            Console.WriteLine("New Customer Added");
            IAlert alt = _driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            alt.Accept();
            Thread.Sleep(2000);
        }
        
        [When(@"Clicks on Open Account Button")]
        public void WhenClicksOnOpenAccountButton()
        {
            IWebElement open = _driver.FindElement(By.XPath("//button[normalize-space()='Open Account']"));
            open.Click();
            Thread.Sleep(2000);
        }

        [When(@"chooses customer name and currency")]
        public void WhenChoosesCustomerNameAndCurrency(Table table)
        {
            foreach (var item in table.Rows)
            {
                IWebElement cust = _driver.FindElement(By.XPath("//select[@id='userSelect']"));
                cust.Click();
                Thread.Sleep(2000);
                var select = new SelectElement(cust);
                Thread.Sleep(2000);
                //select by value
                select.SelectByText(item["cname"]);
                Thread.Sleep(2000);

                IWebElement curr = _driver.FindElement(By.XPath("//select[@id='currency']"));
                curr.Click();
                Thread.Sleep(2000);
                var select2 = new SelectElement(curr);
                Thread.Sleep(2000);
                //select by value
                select2.SelectByValue(item["currency"]);
                Thread.Sleep(2000);

                IWebElement process = _driver.FindElement(By.XPath("//button[normalize-space()='Process']"));
                process.Click();

            }
        }

        [When(@"clicks on Process Button")]
        public void WhenClicksOnProcessButton()
        {
            Console.WriteLine("Account created");   
        }

        [Then(@"new Account gets created")]
        public void ThenNewAccountGetsCreated()
        {
            IAlert alt = _driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            alt.Accept();
            Thread.Sleep(2000);
            Console.WriteLine("new account created");
        }

        [When(@"Clicks on Customer Button")]
        public void WhenClicksOnCustomerButton()
        {
            IWebElement process = _driver.FindElement(By.XPath("//button[normalize-space()='Customers']"));
            process.Click();
            Thread.Sleep(2000);
        }

        [Then(@"Customer data can be viewed")]
        public void ThenCustomerDataCanBeViewed()
        {
            Console.WriteLine("customer data can be viewed");
        }
    }
}
