using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
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
            driver.Url = "http://cn.bing.com";

            var searchBox = driver.FindElement(By.Id("sb_form_q"));
            searchBox.SendKeys("pluralsight");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var imagesLink = driver.FindElement(By.Id("scpl0"));
            imagesLink.Click();

            var div = driver.FindElement(By.ClassName("dg_u"));
            var firstImageLink = div.FindElements(By.TagName("a"))[0];
            firstImageLink.Click();
        }
    }
}
