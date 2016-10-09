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
                new DesiredCapabilities("firefox", "", new Platform(PlatformType.Mac)));
            driver.Url = "http://cn.bing.com";

            var searchBox = driver.FindElement(By.Id("sb_form_q"));
            searchBox.SendKeys("pluralsight");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            var imageLink = driver.FindElement(By.CssSelector("#scpl0"));
            imageLink.Click();

            var firstImageLink = driver.FindElement(By.CssSelector("div.dg_b:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1) > img:nth-child(1)"));
            firstImageLink.Click();
        }
    }
}
