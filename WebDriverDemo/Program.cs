using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"d:\Drivers\webdriver");
            driver.Url = "https://www.google.com";

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("pluralsight");
            searchBox.Submit();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var imagesLink = driver.FindElement(By.XPath("//*[@id=\"hdtb-msb\"]/div[3]/a"));
            imagesLink.Click();

            var firstImageLink = driver.FindElement(By.XPath("//*[@id=\"rg_s\"]/div[1]/a/img"));
            firstImageLink.Click();
        }
    }
}
