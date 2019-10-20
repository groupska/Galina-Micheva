using Homework_SeleniumAdvance.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Homework_SeleniumAdvance
{
    [TestFixture]
    public class POMNegativeTests
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private RegistrationUser _user;
        private ChromeDriver _driver;

        public object UserFactory { get; private set; }

        [SetUp]
        public void CalssInit()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            _loginPage = new LoginPage(driver);
            _regPage = new RegistrationPage(driver);

            _user = Homework_SeleniumAdvance.UserFactory.CreateValidUser();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            this._driver = driver;
            
        }

        [Test]
        public void FillRegistrationFormWithoutFirstName()
        {
            _user.FirstName = "";

            _regPage.Navigate(_loginPage);


            _regPage.FillForm(  _user);

            _regPage.AssertErrorMessage("firstname is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutLastName()
        {
            _user.LastName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("lastname is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutPhoneNumber()
        {
            _user.Phone = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("You must register at least one phone number.");
        }

        //[Test]
        //public void FillRegistrationFormWithoutEmail()
        //{
            

        //    _regPage.Navigate(_loginPage);
        //    _regPage.FillForm(_user);

            
        //    _regPage.AssertErrorMessage("email is required.");
        //}

        [Test]
        public void FillRegistrationFormWithoutPassword()
        {
            _user.Password = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("passwd is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutAddress()
        {
            _user.Address = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("address1 is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutCity()
        {
            _user.City = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("city is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutPosteCode()
        {
            _user.PostCode = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("The Zip/Postal code you've entered is invalid. It must follow this format: 00000");
        }

        [TearDown]

        public void TearDown()
        {
            _driver.Quit();
            
        }
    }

}
