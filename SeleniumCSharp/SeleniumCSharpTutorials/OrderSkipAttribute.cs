using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        IWebDriver driver;

        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            Assert.Ignore("Defect 12345");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            // Lokalizacja chrome.exe
            options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            driver = new ChromeDriver(options);
            driver.Url = "https://www.facebook.com/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)")));
            IWebElement acceptCookiesButton = driver.FindElement(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)"));
            acceptCookiesButton.Click();

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(3000);

            driver.Close();
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            // Lokalizacja chrome.exe
            options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            driver = new ChromeDriver(options);
            driver.Url = "https://www.facebook.com/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)")));
            IWebElement acceptCookiesButton = driver.FindElement(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)"));
            acceptCookiesButton.Click();

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(3000);

            driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)")));
            IWebElement acceptCookiesButton = driver.FindElement(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)"));
            acceptCookiesButton.Click();

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(3000);

            driver.Close();
        }
    }
}
