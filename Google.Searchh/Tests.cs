using Google.Searchh.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Google.Searchh
{
    [TestFixture]
    public class Tests
    {
        private SearchPage _searchPage;
        private ResultPage _resultPage;
        private ChromeDriver _driver;

        [SetUp]
        public void CalssInit()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            _searchPage = new SearchPage(driver);
            _resultPage = new ResultPage(driver);
            
            

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            this._driver = driver;

        }
        [Test]
        public void Search()
        {
            _resultPage.Navigate(_searchPage);

            _resultPage.AssertErrorMessage("Selenium - Web Browser Automation");
        }

        [TearDown]

        public void TearDown()
        {
            _driver.Quit();

        }
    }
}
