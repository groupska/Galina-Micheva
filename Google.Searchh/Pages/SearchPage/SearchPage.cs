using OpenQA.Selenium;

namespace Google.Searchh.Pages
{
    public class SearchPage : BasePage
    {

        public SearchPage(IWebDriver driver)
            : base(driver)
        {

        }

        public new string Url => "http://www.google.com/";

        public IWebElement SearchField => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));

        //public IWebElement Submit => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]"));

        public IWebElement Result => Driver.FindElement(By.CssSelector("#search a:first-child"));
    }
}
