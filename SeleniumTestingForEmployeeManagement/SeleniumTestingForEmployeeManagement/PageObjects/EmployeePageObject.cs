using OpenQA.Selenium;
using SeleniumTestingForEmployeeManagement.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestingForEmployeeManagement.PageObjects
{
    public class EmployeePageObject
    {
        //private const string EmployeeManagementUrl = "https://localhost:44364/";
        Item data = DataReader.Read<Item>(@"H:\Projects\SeleniumTestingForEmployeeManagement\SeleniumTestingForEmployeeManagement\Helper\Data.json");

        private readonly IWebDriver driver;

        public EmployeePageObject(IWebDriver _driver)
        {
            driver = _driver;
        }
       /* public string EmployeePageContent()
        {
            IWebElement textEle = driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/div/h2"));
            String content = textEle.Text;
            return content;
        }*/
        public void DriverClose()
         {
             driver.Close();
            driver.Quit();

         }
        public void NavigateToURL()
        {
            driver.Navigate().GoToUrl(data.url);
        }
        public void ClickToMyPortal()
        {
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a")).Click();
        }
        public void EnterInEmailIDField(string email)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='EmailId']"));
            input.SendKeys(email);
        }
        public void EnterInPasswordField(string password)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='Password']"));
            input.SendKeys(password);
        }
        public void ClickToLogin()
        {
            driver.FindElement(By.XPath("/html/body/div/main/form/div/button")).Submit();
        }
        public void EmployeeClickToEditButton()
        {
            driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div[1]/a")).Click();
        }
        public void ChangeCityTo(string nasik)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='City']"));
            input.Clear();
            input.SendKeys(nasik);
        }
        public void EmployeeClickToSaveChanges()
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/div/main/form/button")).Click();
        }
        public string EmployeeCityUpdatedTo()
        {
            IWebElement textEle = driver.FindElement(By.XPath("/html/body/div/main/div/table/tbody/tr[4]/td"));
            String content = textEle.Text;
            return content;
        }
        public void EmployeeClickLogout()
        { 
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div[2]/a")).Click();

        }
        public string EmployeeSee()
        {
            driver.Manage().Window.Maximize();
            IWebElement textEle = driver.FindElement(By.ClassName("toast-message"));
            String content = textEle.Text;
            return content;


        }
    }
}
