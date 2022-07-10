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
            IWebElement cookieElement = driver.FindElement(By.XPath(".//*[text()='Zezwól na korzystanie z niezbędnych i opcjonalnych plików cookie']"));
            Thread.Sleep(1000);
            cookieElement.Click(); //Accept cookies
            Thread.Sleep(1000);

            IWebElement createAccount = driver.FindElement(By.XPath(".//*[text()='Utwórz nowe konto']"));
            createAccount.Click(); //
            Thread.Sleep(1000);

            IWebElement emailTextField = driver.FindElement(By.Name("reg_email__"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(1000);

            IWebElement monthDropdownList = driver.FindElement(By.Name("birthday_month"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(2); //Select by index
            Thread.Sleep(1000);
            element.SelectByText("lip"); //Select by text
            Thread.Sleep(1000);
            element.SelectByValue("6"); //Select by value
            Thread.Sleep(1000);
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
