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
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");

            driver.Url = "https://m.facebook.com/reg/?privacy_mutation_token=eyJ0eXBlIjowLCJjcmVhdGlvbl90aW1lIjoxNzE4MTI4MTQwLCJjYWxsc2l0ZV9pZCI6MjY5NTQ4NDUzMDcyMDk1MX0%3D";

            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);

            element.SelectByIndex(1); // Select by index
            element.SelectByText("mar"); // Select by text
            element.SelectByValue("6"); // Select by value
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
