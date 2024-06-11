using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.facebook.com/";

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");

            driver.Quit();
        }
    }
}
