using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void InputEmailInLoginTest()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input#email")));
            IWebElement emailTextField = driver.FindElement(By.CssSelector("input#email"));
            emailTextField.SendKeys("Selenium C#");
        }

        // Z powodu błędu poczasu używania tu SetUp i Close, test jest w takiej formie.
        // Działa, ale gdy używam metod nie zawsze działa, ponieważ nie zawsze pojawiają się cookies
        [Test, Category("Smoke Testing")]
        public void ChangeMonthInRegisterTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/reg/?_rdr";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)")));
            IWebElement acceptCookiesButton = driver.FindElement(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)"));
            acceptCookiesButton.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("select[name='birthday_month']")));
            IWebElement birthdayMonthSelect = driver.FindElement(By.CssSelector("select[name='birthday_month']"));

            SelectElement selectElement = new SelectElement(birthdayMonthSelect);

            selectElement.SelectByIndex(8);
            Thread.Sleep(2000);
            selectElement.SelectByText("mar");
            Thread.Sleep(2000);
            selectElement.SelectByValue("1");
        }



        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input#email")));
            IWebElement emailTextField = driver.FindElement(By.CssSelector("input#email"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
