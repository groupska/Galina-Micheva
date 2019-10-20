using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Searchh.Pages
{
    public partial class ResultPage
    {
        public string ErrorMessage => Driver.Title;

        public void AssertErrorMessage(string expected)

        {
            Assert.AreEqual(expected, ErrorMessage);
        }


    }
}
