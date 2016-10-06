using OpenQA.Selenium;
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

            var select = driver.FindElement(By.Id("select1"));

            var selectElement = new SelectElement(select);
            selectElement.SelectByText("Frank");
        }
    }
}
