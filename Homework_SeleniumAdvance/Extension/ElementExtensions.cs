using OpenQA.Selenium;


namespace Homework_SeleniumAdvance.Extension
{
    public static class ElementExtensions
    {
        public static void Type(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}
