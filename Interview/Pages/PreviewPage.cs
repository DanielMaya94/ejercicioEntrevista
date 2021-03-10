using Interview.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Pages
{
    class PreviewPage : Common
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[@id='hlb-view-cart']")]
        [CacheLookup]
        protected IWebElement goToCart { get; set; }

        public PreviewPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        public void clickGoToCart()
        {
            click(goToCart);
        }
    }
}
