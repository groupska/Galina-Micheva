using OpenQA.Selenium;

namespace Homework_SeleniumAdvance.Pages
{
    public class LoginPage : BasePage
    {

        public LoginPage(IWebDriver driver)
            : base(driver)
        {

        }

        public new string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account";

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));
     
    }
}
