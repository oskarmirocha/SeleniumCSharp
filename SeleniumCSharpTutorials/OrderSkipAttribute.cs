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
using SeleniumCSharpTutorials.Utilities;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute 
    {
        [Test,Order(2),Category("OrderSkipAttribute")]
        public void TestMethod1()
        {  
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";

            IWebElement cookieElement = driver.FindElement(By.XPath(".//*[text()='Zezwól na korzystanie z niezbędnych i opcjonalnych plików cookie']"));
            cookieElement.Click(); //Accept cookies

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
        [Test,Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";

            IWebElement cookieElement = driver.FindElement(By.XPath(".//*[text()='Zezwól na korzystanie z niezbędnych i opcjonalnych plików cookie']"));
            cookieElement.Click(); //Accept cookies

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/";

            IWebElement cookieElement = driver.FindElement(By.XPath(".//*[text()='Zezwól na korzystanie z niezbędnych i opcjonalnych plików cookie']"));
            cookieElement.Click(); //Accept cookies

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
