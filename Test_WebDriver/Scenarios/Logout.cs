using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebDriver.Scenarios
{
    internal class Logout
    {
        [SetUp]
        public void Setup()
        {
            Action.InitializeDriver(Config.Url);
        }

        [Test]
        public void Logout_Valid()
        {
            IWebElement usernameInput = Driver.driver.FindElement(By.Id("user-name"));
            usernameInput.SendKeys(Config.Credentials.Valid.Username);

            IWebElement passwordInput = Driver.driver.FindElement(By.Id("password"));
            passwordInput.SendKeys(Config.Credentials.Valid.Password);

            IWebElement loginbutton = Driver.driver.FindElement(By.Id("login-button"));
            loginbutton.Click();

            IWebElement hamburgerMenu = Driver.driver.FindElement(By.Id("react-burger-menu-btn"));
            hamburgerMenu.Click();

            System.Threading.Thread.Sleep(1000);

            IWebElement logoutbutton = Driver.driver.FindElement(By.Id("logout_sidebar_link"));
            logoutbutton.Click();

            System.Threading.Thread.Sleep(1000);

            IWebElement loginredirect = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div"));
            Assert.IsTrue(loginredirect.Displayed);
        }
    }
}
