using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestingForEmployeeManagement.PageObjects;
using System;
using TechTalk.SpecFlow;


namespace SeleniumTestingForEmployeeManagement.StepDefinitions
{
    
    [Binding]
    public class EmployeeTestingStepDefinitions
    {
        private readonly EmployeePageObject empPageObject;
        IWebDriver driver = new ChromeDriver();

        public EmployeeTestingStepDefinitions()
        {
            empPageObject = new EmployeePageObject(driver);
        }

        [Given(@"Employee navigate to URL")]
        public void GivenEmployeeNavigateToURL()
        {
            empPageObject.NavigateToURL();

        }

        [Given(@"Employee click to MyPortal")]
        public void GivenEmployeeClickToMyPortal()
        {
            empPageObject.ClickToMyPortal();
        }

        [Given(@"Employee enter ""([^""]*)"" in emailID field")]
        public void GivenEmployeeEnterInEmailIDField(string email)
        {
            empPageObject.EnterInEmailIDField(email);
        }

        [Given(@"Employee enter ""([^""]*)"" in password field")]
        public void GivenEmployeeEnterInPasswordField(string password)
        {
            empPageObject.EnterInPasswordField(password);
        }


        [When(@"Employee click to login")]
        public void WhenEmployeeClickToLogin()
        {
            empPageObject.ClickToLogin();
        }

        [Then(@"Employee can see ""([^""]*)""")]
        public void ThenEmployeeCanSee(string message)
        {
            string text = empPageObject.EmployeeSee();
            Console.WriteLine("Content: " + text);
            Assert.IsTrue(text.Contains(message));
            empPageObject.DriverClose();
        }

        [Given(@"Employee Click to login")]
        public void GivenEmployeeClickToLogin()
        {
            empPageObject.ClickToLogin();
        }


       

        [Given(@"Employee click to edit button")]
        public void GivenEmployeeClickToEditButton()
        {
            empPageObject.EmployeeClickToEditButton();
        }

        /*[Given(@"Change city to ""([^""]*)""")]
        public void GivenChangeCityTo(string nasik)
        {
            empPageObject.ChangeCityTo(nasik);
        }*/

        [Given(@"Change city to (.*)")]
        public void GivenChangeCityToCity(string city)
        {
            empPageObject.ChangeCityTo(city);
        }



        [When(@"Employee click to Save Changes")]
        public void WhenEmployeeClickToSaveChanges()
        {
            empPageObject.EmployeeClickToSaveChanges();
        }

        /*[Then(@"Employee city updated to ""([^""]*)""")]
        public void ThenEmployeeCityUpdatedTo(string nasik)
        {
            string text = empPageObject.EmployeeCityUpdatedTo();
            Console.WriteLine("Content: " + text);
            Assert.IsTrue(text.Contains(nasik));
            empPageObject.DriverClose();
        }*/
        [Then(@"Employee city updated to (.*)")]
        public void ThenEmployeeCityUpdatedToResult(string result)
        {
            string text = empPageObject.EmployeeCityUpdatedTo();
            Console.WriteLine("Content: " + text);
            Assert.IsTrue(text.Contains(result));
            empPageObject.DriverClose();
        }

        [When(@"Employee click logout")]
        public void WhenEmployeeClickLogout()
        {
            empPageObject.EmployeeClickLogout();
        }

        [Then(@"Employee see ""([^""]*)""")]
        public void ThenEmployeeSee(string p0)
        {
            string text = empPageObject.EmployeeSee();
            Console.WriteLine("Content: " + text);
            Assert.IsTrue(text.Contains(p0));
            empPageObject.DriverClose();
        }


    }
}
