using OpenQA.Selenium;


namespace Google.Searchh.Pages
{
    public partial class ResultPage : BasePage
    {
        public ResultPage(IWebDriver driver)
            : base(driver)
        {

        }

        public void Navigate(SearchPage searchPage)
        {
            searchPage.Navigate("https://www.google.com/");

            searchPage.SearchField.SendKeys("Selenium");
            searchPage.SearchField.SendKeys(Keys.Enter);
            searchPage.Result.Click();
        }
    }
}
