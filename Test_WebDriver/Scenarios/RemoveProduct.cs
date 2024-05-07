using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebDriver.Scenarios
{
    internal class RemoveProduct
    {
        [SetUp]
        public void Setup()
        {
            Action.InitializeDriver(Config.Url);
        } 

        [Test]
        public void Remove_From_Cart_Valid()
        {
            IWebElement usernameInput = Driver.driver.FindElement(By.Id("user-name"));
            usernameInput.SendKeys(Config.Credentials.Valid.Username);

            IWebElement passwordInput = Driver.driver.FindElement(By.Id("password"));
            passwordInput.SendKeys(Config.Credentials.Valid.Password);

            IWebElement loginbutton = Driver.driver.FindElement(By.Id("login-button"));
            loginbutton.Click();

            IWebElement addToCartButton = Driver.driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            string initialButtonText = addToCartButton.Text;
            addToCartButton.Click();

            System.Threading.Thread.Sleep(2000);

            IWebElement removeFromCartButton = Driver.driver.FindElement(By.Id("remove-sauce-labs-backpack"));
            string buttonTextAfterClick = removeFromCartButton.Text;
            removeFromCartButton.Click();

            Assert.AreNotEqual(initialButtonText, buttonTextAfterClick);
        }
    }
}

