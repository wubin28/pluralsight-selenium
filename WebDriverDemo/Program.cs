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

            var outerTable = driver.FindElement(By.TagName("table"));
            var innerTable = outerTable.FindElement(By.TagName("table"));
            var row = innerTable.FindElements(By.TagName("td"))[1];
            Console.WriteLine(row.Text);
        }
    }
}
