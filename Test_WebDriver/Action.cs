using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebDriver
{
    internal class Action
    {
        public static void InitializeDriver(string url = "")
        {
            if (string.IsNullOrEmpty(url))
                url = Config.Url;

            Driver.driver = new ChromeDriver("C:\\Users\\plane\\Downloads\\chromedriver-win32 (1)\\chromedriver-win32");

            Driver.driver.Navigate().GoToUrl(url);
            Driver.driver.Manage().Window.Maximize();
        }
    }
}
