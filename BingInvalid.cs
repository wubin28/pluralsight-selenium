using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class BingInvalid
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://cn.bing.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheBingInvalidTest()
        {
            // open | / | 
            driver.Navigate().GoToUrl(baseURL + "/");
            // click | id=id_s | 
            driver.FindElement(By.Id("id_s")).Click();
            // click | css=span.id_name | 
            driver.FindElement(By.CssSelector("span.id_name")).Click();
            // type | id=i0116 | wubin28@gmail.com
            driver.FindElement(By.Id("i0116")).Clear();
            driver.FindElement(By.Id("i0116")).SendKeys("wubin28@gmail.com");
            // type | id=i0118 | puT2RuN9
            driver.FindElement(By.Id("i0118")).Clear();
            driver.FindElement(By.Id("i0118")).SendKeys("puT2RuN9");
            // type | id=i0116 | invalid
            driver.FindElement(By.Id("i0116")).Clear();
            driver.FindElement(By.Id("i0116")).SendKeys("invalid");
            // type | id=i0118 | invalid
            driver.FindElement(By.Id("i0118")).Clear();
            driver.FindElement(By.Id("i0118")).SendKeys("invalid");
            // click | id=idSIButton9 | 
            driver.FindElement(By.Id("idSIButton9")).Click();
            // assertTitle | Sign in to your Microsoft account | 
            Assert.AreEqual("Sign in to your Microsoft account", driver.Title);
            // verifyText | id=usernameError | Please enter your phone number or your email address in the format someone@example.com.
            try
            {
                Assert.AreEqual("Please enter your phone number or your email address in the format someone@example.com.", driver.FindElement(By.Id("usernameError")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
