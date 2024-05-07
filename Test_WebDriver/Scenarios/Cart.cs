using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebDriver.Scenarios
{
    internal class Cart
    {
        [SetUp]
        public void Setup()
        {
            Action.InitializeDriver(Config.Url);
        }

        [Test]
        public void removeProductFromCart_Valid()
        {
            IWebElement usernameInput = Driver.driver.FindElement(By.Id("user-name"));
            usernameInput.SendKeys(Config.Credentials.Valid.Username);

            IWebElement passwordInput = Driver.driver.FindElement(By.Id("password"));
            passwordInput.SendKeys(Config.Credentials.Valid.Password);

            IWebElement loginbutton = Driver.driver.FindElement(By.Id("login-button"));
            loginbutton.Click();

            IWebElement addToCartButton = Driver.driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            addToCartButton.Click();

            IWebElement cartIcon = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div[1]/div[3]/a"));
            cartIcon.Click();

            IWebElement removeProduct = Driver.driver.FindElement(By.Id("remove-sauce-labs-backpack"));
            removeProduct.Click();

            IWebElement successIndicator = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/span"));
            Assert.IsTrue(successIndicator.Displayed);
        }
    }
}