﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WebDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            login.Setup();
        }
    }
}
