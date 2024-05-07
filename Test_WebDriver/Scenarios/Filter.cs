using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebDriver.Scenarios
{
    internal class Filter
    {
        [SetUp]
        public void Setup()
        {
            Action.InitializeDriver(Config.Url);
        }

        [Test]
        public void Filtering_Valid()
        {
            IWebElement usernameInput = Driver.driver.FindElement(By.Id("user-name"));
            usernameInput.SendKeys(Config.Credentials.Valid.Username);

            IWebElement passwordInput = Driver.driver.FindElement(By.Id("password"));
            passwordInput.SendKeys(Config.Credentials.Valid.Password);

            IWebElement loginbutton = Driver.driver.FindElement(By.Id("login-button"));
            loginbutton.Click();

            IWebElement filterbutton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/span/select"));
            filterbutton.Click();

            System.Threading.Thread.Sleep(1000);

            IWebElement zToAbutton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[2]/div/span/select/option[3]"));
            zToAbutton.Click();

            IWebElement filteredResultRow = Driver.driver.FindElement(By.Id("inventory_container"));
            Assert.NotNull(filteredResultRow);
        }
    } 
}