using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"),
                DesiredCapabilities.Firefox());
            driver.Url = "http://www.google.com";

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("pluralsight");
            searchBox.Submit();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            var dropdownItem = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[2]/div[2]/div[1]/div[2]/div[2]/div[1]/div/ul/li[1]/div/div[1]"));
            dropdownItem.Click();

            var imageLink = driver.FindElement(By.CssSelector("div.hdtb-mitem:nth-child(5) > a:nth-child(1)"));
            imageLink.Click();
            
            var firstImageLink = driver.FindElement(By.XPath("//*[@id=\"rg_s\"]/div[1]/a/img"));
            firstImageLink.Click();
        }
    }
}
