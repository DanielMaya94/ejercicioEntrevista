using Interview.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Pages
{
    class RegisterPage : Common
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@id='ap_customer_name']")]
        [CacheLookup]
        private IWebElement nameBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='ap_email']")]
        [CacheLookup]
        private IWebElement emailBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'condition_of_use')]")]
        [CacheLookup]
        private IWebElement conditionOfUse { get; set; }

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public void clickConditionsOfUse()
        {
            click(conditionOfUse);
        }
    }
}
