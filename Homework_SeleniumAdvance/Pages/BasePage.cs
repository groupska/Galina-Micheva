using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Homework_SeleniumAdvance.Pages
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => _wait;

        public virtual void Navigate(string Url)
        {
            Driver.Url = Url;
        }


    }
}

