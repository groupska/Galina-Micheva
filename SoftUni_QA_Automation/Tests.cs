using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SoftUni_QA_Automation.Pages;
using System;
using System.IO;
using System.Reflection;

namespace SoftUni_QA_Automation
{
    [TestFixture]
    public class Tests
    {
        private TitlePage _titlePage;
        private QAPage _qaPage;
        private ChromeDriver _driver;

        [SetUp]
        public void CalssInit()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            _titlePage = new TitlePage(driver);
            _qaPage = new QAPage(driver);

           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            this._driver = driver;

        }

        [Test]
        public void FillRegistrationFormWithoutPosteCode()
        {
            _qaPage.Navigate(_titlePage);
            
            _qaPage.AssertErrorMessage("QA Automation - септември 2019");
        }

        [TearDown]

        public void TearDown()
        {
            _driver.Quit();
            
        }
    }
}
