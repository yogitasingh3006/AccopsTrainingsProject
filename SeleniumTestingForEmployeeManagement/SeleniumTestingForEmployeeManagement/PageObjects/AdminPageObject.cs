using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumTestingForEmployeeManagement.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestingForEmployeeManagement.PageObjects
{
    public class AdminPageObject
    {
        //private const string EmployeeManagementUrl = "https://localhost:44364/";
        Item data = DataReader.Read<Item>(@"H:\Projects\SeleniumTestingForEmployeeManagement\SeleniumTestingForEmployeeManagement\Helper\Data.json");
        private readonly IWebDriver driver;

        public AdminPageObject(IWebDriver _driver)
        {
            driver = _driver;
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
        public string EmailErrorMsg()
        {
            IWebElement emailTextEle = driver.FindElement(By.XPath("/html/body/div/main/form/div/div[2]/span"));
            String emailError = emailTextEle.Text;
            return emailError;
        }
        public string PasswordErrorMsg()
        {
            IWebElement passwordTextEle = driver.FindElement(By.XPath("/html/body/div/main/form/div/div[3]/span"));
            String passwordError = passwordTextEle.Text;
            return passwordError;
        }
        public string AdminPageContent()
        {
            IWebElement textEle = driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/div[1]/h2"));
            String content = textEle.Text;
            return content;
        }
        public void AdminClickToAddDepartment()
        {
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/div[3]/a")).Click();
        }
        public void AdminEnterDepartment(string department)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='DepartName']"));
            input.Clear();
            input.SendKeys(department);
        }
        public void AdminClickCreate()
        {
            driver.FindElement(By.XPath("/html/body/div/main/form/div/button")).Click();
        }
        public string AdminCanSeeMessage()
        {
            
                IWebElement textEle = driver.FindElement(By.ClassName("toast-message"));
                String content = textEle.Text;
                return content;
            
        }
        public void AdminClickToDeleteForSpecificUser(string id)
        {
            try
            {
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id(id)).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("User that to be deleted do not exist");
                Console.WriteLine(e.Message);

            }
        }
        public void AdminClickDelete()
        {
            //IWebElement element = driver.FindElement(By.Id("Delete"));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element).Click().Build().Perform();
            try
            {
                driver.FindElement(By.Id("Delete")).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot Delete as User do not exist");
                Console.WriteLine(e.Message);

            }


        }
        public void AdminClickToEditForSpecificUserById(string id)
        {
            try
            {
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id(id)).Click();
            }
            catch(Exception e)
            {
                Console.WriteLine("User that to be edited do not exist");
                Console.WriteLine(e.Message);
            }
        }
        public void ChangeRoleTo(string role)
        {
            try
            {
                IWebElement input = driver.FindElement(By.XPath("//*[@id='Role']"));
                SelectElement select = new SelectElement(input);
                select.SelectByText(role);
            }
            catch(Exception e)
            {
                Console.WriteLine("Role cannot be change as user do not exist");
                Console.WriteLine(e.Message);

            }
            
        }
        public void AdminClickEdit()
        {
            try
            {
                driver.FindElement(By.XPath("/html/body/div/main/form/div/button")).Click();
            }
            catch(Exception e)
            {
                Console.WriteLine("User details cannot be edited");
                Console.WriteLine(e.Message);
            }
        }
        
        public void AdminClickToAddUser()
        {
            driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/div[2]/a")).Click();
        }
        public void EnterEmpName(string name)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='EmpName']"));
            input.Clear();
            input.SendKeys(name);
        }
        public void EnterEmailId(string mail)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='EmailId']"));
            input.Clear();
            input.SendKeys(mail);
        }
        public void EnterPassword(string pass)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='Password']"));
            input.Clear();
            input.SendKeys(pass);
        }
        public void EnterConfirmPassword(string cPass)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='ConfirmPassword']"));
            input.Clear();
            input.SendKeys(cPass);
        }
        public void EnterCity(string city)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='City']"));
            input.Clear();
            input.SendKeys(city);
        }

        public void EnterPhone(string phone)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='Phone']"));
            input.Clear();
            input.SendKeys(phone);
        }
        public void AdminSelectDepartmentName(string department)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='DepartName']"));
            SelectElement select = new SelectElement(input);
            select.SelectByText(department);
        }
        public void AdminSelectRole(string role)
        {
            IWebElement input = driver.FindElement(By.XPath("//*[@id='Role']"));
            SelectElement select = new SelectElement(input);
            select.SelectByText(role);

        }
        [When(@"Admin click Add")]
        public void WhenAdminClickAdd()
        {
            driver.FindElement(By.XPath("/html/body/div/main/form/div/button")).Click();
        }
        public void DriverClose()
        {
            driver.Close();
            //driver.Quit();

        }
    }
}
