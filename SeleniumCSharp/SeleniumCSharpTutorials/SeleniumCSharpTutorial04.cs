using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        IWebDriver driver = null;

        [Test]
        [Author("User", "user@example.com")]
        [Description("Facebook login Verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--no-sandbox");
                options.AddArgument("--disable-dev-shm-usage");
                // Lokalizacja chrome.exe
                options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

                driver = new ChromeDriver(options);
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)")));
                IWebElement acceptCookiesButton = driver.FindElement(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)"));
                acceptCookiesButton.Click();

                //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium C#");
                Thread.Sleep(1500);

                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile(@"D:\VS Solutions\Testy-Projekt-Zaliczeniowy\SeleniumCSharp\SeleniumCSharpTutorials\Screenshots\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            list.Add("https://www.youtube.com/");
            list.Add("https://www.gmail.com/");
            return list;
        }

        //[Test]
        //[Author("User", "user@example.com")]
        //[Description("Facebook login Verify")]
        //public void Test2()
        //{
        //    ChromeOptions options = new ChromeOptions();
        //    options.AddArgument("--no-sandbox");
        //    options.AddArgument("--disable-dev-shm-usage");
        //    // Lokalizacja chrome.exe
        //    options.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

        //    IWebDriver driver = new ChromeDriver(options);
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/";

        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //    wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)")));
        //    IWebElement acceptCookiesButton = driver.FindElement(By.CssSelector("div._10.uiLayer._4-hy._3qw > div._59s7._9l2g > div > div > div > div > div:nth-child(3) > div.x1exxf4d.x13fuv20.x178xt8z.x1l90r2v.x1pi30zi.x1swvt13 > div > div:nth-child(2)"));
        //    acceptCookiesButton.Click();

        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    Thread.Sleep(1500);

        //    driver.Quit();
        //}

    }
}
