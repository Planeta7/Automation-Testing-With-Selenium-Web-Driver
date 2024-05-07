using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebDriver.Scenarios
{
    internal class Checkout
    {
        [SetUp]
        public void Setup()
        {
            Action.InitializeDriver(Config.Url);
        }

        [Test]
        public void TestCheckout_Valid()
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

            IWebElement checkoutbutton = Driver.driver.FindElement(By.Id("checkout"));
            checkoutbutton.Click();

            IWebElement firstnameInput = Driver.driver.FindElement(By.Id("first-name"));
            firstnameInput.SendKeys("Test");
            IWebElement lastInput = Driver.driver.FindElement(By.Id("last-name"));
            lastInput.SendKeys("Test LN");
            IWebElement postCodeInput = Driver.driver.FindElement(By.Id("postal-code"));
            postCodeInput.SendKeys("10000");

            IWebElement continueButton = Driver.driver.FindElement(By.Id("continue"));
            continueButton.Click();

            IWebElement finnishButton = Driver.driver.FindElement(By.Id("finish"));
            finnishButton.Click();

            IWebElement successIndicator = Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/h2"));
            Assert.IsTrue(successIndicator.Displayed);
        }
    }
}