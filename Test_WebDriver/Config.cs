using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebDriver
{
    internal class Config
    {
        public static string Url = "https://www.saucedemo.com/";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "standard_user";
                public static string Password = "secret_sauce";
            }
            public static class Invalid
            {
                public static string Username = "standard_user";
                public static string Password = "s";
            }
        }
    }
}