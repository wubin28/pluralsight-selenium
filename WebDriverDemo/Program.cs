using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var imagesLink = wait.Until(d =>
                            {
                                return driver.FindElement(By.XPath("//*[@id=\"hdtb-msb\"]/div[2]/a"));
                            });

            imagesLink.Click();

            var firstImageLink = driver.FindElement(By.XPath("//*[@id=\"rg_s\"]/div[1]/a/img"));
            firstImageLink.Click();
        }
    }
}
