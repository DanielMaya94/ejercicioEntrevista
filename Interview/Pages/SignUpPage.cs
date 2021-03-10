using Interview.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Pages
{
    class SignUpPage : Common
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        [CacheLookup]
        private IWebElement createAccountButton { get; set; }

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        public void registerAccount()
        {
            click(createAccountButton);
        }
    }
}
