using NUnit.Framework;
using OpenQA.Selenium;


namespace SoftUni_QA_Automation.Pages
{
    public partial class QAPage
    {
        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("/html/body/div[2]/header/h1"));

        public void AssertErrorMessage(string expected)

        {
            Assert.AreEqual(expected, ErrorMessage.Text);
        }


    }
}
