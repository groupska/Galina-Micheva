
using OpenQA.Selenium;

namespace SoftUni_QA_Automation.Pages
{
    public partial class QAPage : BasePage
    {
        public QAPage(IWebDriver driver)
           : base(driver)
        {

        }

        public void Navigate(TitlePage titlePage)
        {
            titlePage.Navigate("https://softuni.bg/");

            titlePage.Courses.Click();
            titlePage.Qa.Click();
        }

      
    }
}
