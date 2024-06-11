using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)")));
                IWebElement acceptCookiesButton = driver.FindElement(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)"));
                acceptCookiesButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie udało się kliknąć przycisku akceptacji plików cookie: " + ex.Message);
            }
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
