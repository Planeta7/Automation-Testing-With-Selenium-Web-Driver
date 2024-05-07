using NUnit.Framework.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Test_WebDriver
{
    internal class Login
    {
        [SetUp]
        public void Setup()
        {
            Action.InitializeDriver(Config.Url);
        }

        [Test]
        public void TestLogin_Valid()
        {
            IWebElement usernameInput = Driver.driver.FindElement(By.Id("user-name"));
            usernameInput.SendKeys(Config.Credentials.Valid.Username);

            IWebElement passwordInput = Driver.driver.FindElement(By.Id("password"));
            passwordInput.SendKeys(Config.Credentials.Valid.Password);

            IWebElement loginbutton = Driver.driver.FindElement(By.Id("login-button"));
            loginbutton.Click();

            IWebElement successIndicator = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[2]/div"));
            Assert.IsTrue(successIndicator.Displayed);
        }

        [Test]
        public void TestLogin_Invalid()
        {
            IWebElement usernameInput = Driver.driver.FindElement(By.Id("user-name"));
            usernameInput.SendKeys(Config.Credentials.Invalid.Username);

            IWebElement passwordInput = Driver.driver.FindElement(By.Id("password"));
            passwordInput.SendKeys(Config.Credentials.Invalid.Password);

            IWebElement loginbutton = Driver.driver.FindElement(By.Id("login-button"));
            loginbutton.Click();

            IWebElement failIndicator = Driver.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div/div/form/div[3]"));
            Assert.IsTrue(failIndicator.Displayed);
        }
    }
}
