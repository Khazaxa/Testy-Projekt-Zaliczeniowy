using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void Open()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            // Lokalizacja chrome.exe
            options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            AcceptCookies();
        }

        public void AcceptCookies()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)")));
            IWebElement acceptCookiesButton = driver.FindElement(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)"));
            acceptCookiesButton.Click();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void Close()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

    }
}
