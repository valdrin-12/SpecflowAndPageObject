using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CsharpSelenium2022.Pages
{
    internal class HomePage :DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogoff => Driver.FindElement(By.LinkText("Log off"));


        public void Clicklogin() => lnkLogin.Click();


        public bool IsLogOffExists() => lnkLogoff.Displayed;
//# logoutForm > ul > li:nth-child(2) > a

    }
}
