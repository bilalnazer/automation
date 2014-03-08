using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestDemo
{
    [TestClass]
    public class LoginTest
    {
        public static IWebDriver WebDriver;

        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            var internetExplorerOptions = new InternetExplorerOptions
                                    { IntroduceInstabilityByIgnoringProtectedModeSettings = true, IgnoreZoomLevel = true };
            WebDriver = new InternetExplorerDriver(internetExplorerOptions);
        }

        [TestMethod]
        public void NopCommerceLoginPageTest()
        {
            WebDriver.Navigate().GoToUrl("http://localhost:36824/login");
            IWebElement email = WebDriver.FindElement(By.Id("Email"));
            IWebElement password = WebDriver.FindElement(By.Id("Password"));

            email.Clear();
            email.SendKeys(Keys.Home + "meetnbilal@gmail.com");

            password.Clear();
            password.SendKeys(Keys.Home + "admin");

            password.Submit();

            //Wait logic may required in real cases..
            //WebDriverWait wait = new WebDriverWait(WebDriver, new TimeSpan(0,0,10));

            IWebElement logout = WebDriver.FindElement(By.ClassName("ico-logout"));
            Assert.IsTrue(logout.Text == "Log out");
        }

        [TestMethod]
        public void NopCommerceSearch()
        {
            WebDriver.Navigate().GoToUrl("http://localhost:36824");
            IWebElement searchBox = WebDriver.FindElement(By.Id("small-searchterms"));
            searchBox.SendKeys(Keys.Home + "Camera");
            searchBox.Submit();

        }
    }
}
