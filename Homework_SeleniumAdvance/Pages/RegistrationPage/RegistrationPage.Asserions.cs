using NUnit.Framework;
using OpenQA.Selenium;


namespace Homework_SeleniumAdvance.Pages
{
    public partial class RegistrationPage
    {
            public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol"));

            public void AssertErrorMessage(string expected)

            {
                Assert.AreEqual(expected, ErrorMessage.Text);
            }

    
    }
}
