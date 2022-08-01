using CsharpSelenium2022.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CsharpSelenium2022.Steps
{


    [Binding]
    public class Loginsteps:DriverHelper
    {
        HomePage homepage = new HomePage();
        LoginPage loginpage = new LoginPage();




        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }


        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            homepage.Clicklogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.EnterUserNameAndPassword(data.UserName, data.Password);

        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loginpage.ClickLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.That(homepage.IsLogOffExists(), Is.True, "log off button is not displayed");
        }


    }
}
