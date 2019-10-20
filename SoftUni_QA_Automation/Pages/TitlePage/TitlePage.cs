using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SoftUni_QA_Automation.Pages
{
    public class TitlePage : BasePage
    {

        public TitlePage(IWebDriver driver)
            : base(driver)
        {

        }

        public new string Url => "http://softuni.bg/";

        public IWebElement Courses => Driver.FindElement(By.XPath("//*[@id='header-nav']/div[1]/ul/li[2]/a"));

        
        public IWebElement Qa => Driver.FindElement(By.XPath("//a[contains(text(), 'QA Automation - септември 2019')]"));
    }
}
