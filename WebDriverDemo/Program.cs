﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"D:\Drivers\webdriver\");
            driver.Url = @"file:///D:/ben/pluralsight-selenium/WebDriverDemo/WebDriverDemo/TestPage.html";

            var row = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
            Console.WriteLine(row.Text);
        }
    }
}
