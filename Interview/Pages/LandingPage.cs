using Interview.Utils;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;

namespace Interview.Pages
{
    class LandingPage : Common
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        [CacheLookup]
        private IWebElement searchBox { get; set; }

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        [CacheLookup]
        private IWebElement searchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='nav-link-accountList']")]
        [CacheLookup]
        private IWebElement signInButton { get; set; }



        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;

           PageFactory.InitElements(driver, this);

        }

        public void search(string text)
        {
            sendKeys(searchBox, text);
            click(searchIcon);
        }

        public void clickSignUp()
        {
            click(signInButton);
        }
        
    }
}
