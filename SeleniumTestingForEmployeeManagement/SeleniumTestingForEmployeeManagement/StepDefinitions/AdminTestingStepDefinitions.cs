using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestingForEmployeeManagement.PageObjects;
using System;
using TechTalk.SpecFlow;

//[assembly: Parallelizable(ParallelScope.All)]

namespace SeleniumTestingForEmployeeManagement.StepDefinitions
{
    [Binding]
    public class AdminTestingStepDefinitions
    {
        private readonly AdminPageObject adminPageObject;
        IWebDriver driver=new ChromeDriver();

        public AdminTestingStepDefinitions()
        {
            adminPageObject = new AdminPageObject(driver);
        }
        //[Given(@"User navigate to URL ""([^""]*)""")]
        //public void GivenUserNavigateToURL(string url)
        //{
        //    adminPageObject.NavigateToURL(url);
        //}
        [Given(@"User navigate to URL")]
        public void GivenUserNavigateToURL()
        {
            adminPageObject.NavigateToURL();
        }

        [Given(@"User click to MyPortal")]
        public void GivenUserClickToMyPortal()
        {
            adminPageObject.ClickToMyPortal();
        }

        [Given(@"User enter ""([^""]*)"" in emailID field")]
        public void GivenUserEnterInEmailIDField(string email)
        {
            adminPageObject.EnterInEmailIDField(email);
        }

        [Given(@"User enter ""([^""]*)"" in password field")]
        public void GivenUserEnterInPasswordField(string password)
        {
            adminPageObject.EnterInPasswordField(password);
        }

        [When(@"User click to login")]
        public void WhenUserClickToLogin()
        {
            adminPageObject.ClickToLogin();
        }


        [Then(@"User see error message")]
        public void ThenUserSeeErrorMessage()
        {
            String emailError = adminPageObject.EmailErrorMsg();
            String passwordError = adminPageObject.PasswordErrorMsg();
            Console.WriteLine("Email error: " + emailError);
            Console.WriteLine("Password error: " + passwordError);
            Assert.IsTrue(emailError.Contains("Please Enter emailId"));
            Assert.IsTrue(passwordError.Contains("Please Enter Password"));
            adminPageObject.DriverClose();
        }

        [Then(@"Admin can see ""([^""]*)""")]
        public void ThenICanSee(string adminPageContent)
        {
            String content = adminPageObject.AdminPageContent();
            Console.WriteLine("Content: " + content);
            Assert.IsTrue(content.Contains(adminPageContent));
            adminPageObject.DriverClose();
            
        }
        [Given(@"User click to login")]
        public void GivenUserClickToLogin()
        {
            adminPageObject.ClickToLogin();
        }
        [Given(@"Admin click to Add department")]
        public void GivenAdminClickToAddDepartment()
        {
            adminPageObject.AdminClickToAddDepartment();
        }
        [Given(@"Admin enter (.*)")]
        public void GivenAdminEnterDepartment(string department)
        {
            adminPageObject.AdminEnterDepartment(department);
        }
        [When(@"Admin click Create")]
        public void WhenAdminClickCreate()
        {
            adminPageObject.AdminClickCreate();
        }
        [Then(@"Admin can see notification (.*)")]
        public void ThenAdminCanSeeNotification(string message)
        {
            string content = adminPageObject.AdminCanSeeMessage();
            Console.WriteLine(content);
            Console.WriteLine(message);
            Assert.IsTrue(content.Contains(message));
            driver.Close();
        }

        [Given(@"Admin click to Delete for specific user by Id ""([^""]*)""")]
        public void GivenAdminClickToDeleteForSpecificUserBy(string id)
        { 
            adminPageObject.AdminClickToDeleteForSpecificUser(id);
            
        }

        [When(@"Admin click delete")]
        public void WhenAdminClickDelete()
        {

            adminPageObject.AdminClickDelete();
            
        }
        [Then(@"Admin can see deleted successfull message ""([^""]*)""")]
        public void ThenAdminCanSeeSuccessfullMessage(string message)
        {
            
            string content = adminPageObject.AdminCanSeeMessage();
            if (content != "Login Successfully")
            {
                Console.WriteLine(content);
                Console.WriteLine(message);
                Assert.IsTrue(content.Contains(message));
            }
            else
            {
                Console.WriteLine("User cannot be Deleted");
            }

            adminPageObject.DriverClose();
        }


        [Given(@"Admin click to Edit for specific user by Id ""([^""]*)""")]
        public void GivenAdminClickToEditForSpecificUserById(string id)
        {
            adminPageObject.AdminClickToEditForSpecificUserById(id);
        }
        [Given(@"Change role to (.*)")]
        public void GivenChangeRoleTo(string role)
        {
            adminPageObject.ChangeRoleTo(role);
        }

        [When(@"Admin click update")]
        public void WhenAdminClickEdit()
        {
            adminPageObject.AdminClickEdit();
            
        }
        [Then(@"Admin can see updation successfull message ""([^""]*)""")]
        public void ThenAdminCanSeeUpdationSuccessfullMessage(string message)
        {
            string content = adminPageObject.AdminCanSeeMessage();
            if (content == "Login Successfully")
            {
                Console.WriteLine("User Details cannot be edited");
               
            }
            else
            {
                Console.WriteLine(content);
                Console.WriteLine(message);
                Assert.IsTrue(content.Contains(message));
            }

            adminPageObject.DriverClose();
        }

        [Given(@"Admin click to AddUser")]
        public void GivenAdminClickToAddUser()
        {
            adminPageObject.AdminClickToAddUser();
        }

        [Given(@"enter EmpName (.*)")]
        public void GivenEnterEmpName(string name)
        {
            adminPageObject.EnterEmpName(name);
        }
        [Given(@"enter EmailId (.*)")]
        public void GivenEnterEmailId(string mail)
        {
            adminPageObject.EnterEmailId(mail);
        }
        [Given(@"enter Password (.*)")]
        public void GivenEnterPassword(string pass)
        {
            adminPageObject.EnterPassword(pass);
        }
        [Given(@"enter Confirm Password (.*)")]
        public void GivenEnterConfirmPassword(string cPass)
        {
            adminPageObject.EnterConfirmPassword(cPass);
        }

        [Given(@"enter City (.*)")]
        public void GivenEnterCity(string city)
        {
            adminPageObject.EnterCity(city);
        }

        [Given(@"enter phone (.*)")]
        public void GivenEnterPhone(string phone)
        {
            adminPageObject.EnterPhone(phone);
        }

        [Given(@"Admin select Department name (.*)")]
        public void GivenAdminSelectDepartmentName(string department)
        {
            adminPageObject.AdminSelectDepartmentName(department);
        }
        [Given(@"Admin select Role (.*)")]
        public void GivenAdminSelectRole(string role)
        {
            adminPageObject.AdminSelectRole(role);
        }
        [When(@"Admin click Add")]
        public void WhenAdminClickAdd()
        {
            adminPageObject.WhenAdminClickAdd();
        }
        [Then(@"Admin can see addded successfull message ""([^""]*)""")]
        public void ThenAdminCanSeeAdddedSuccessfullMessage(string message)
        {
            string content = adminPageObject.AdminCanSeeMessage();
            if (content == "Email already exists")
            {
                Console.WriteLine("User cannot be added as email already exists");
            }
            else
            {
                Console.WriteLine(content);
                Console.WriteLine(message);
                Assert.IsTrue(content.Contains(message));
            }

            adminPageObject.DriverClose();
        }


    }
}
