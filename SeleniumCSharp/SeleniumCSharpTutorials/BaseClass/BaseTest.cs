using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [OneTimeSetUp]
        public void Open()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
