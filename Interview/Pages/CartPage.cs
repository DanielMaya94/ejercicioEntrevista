using Interview.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Pages
{
    class CartPage : Common, Interface
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'product-price')]")]
        [CacheLookup]
        protected IWebElement cartPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-item-count='1']//input[contains(@name,'submit.delete')]")]
        [CacheLookup]
        protected IWebElement deleteItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'cart-is-empty')]")]
        [CacheLookup]
        protected IWebElement emptyCart { get; set; }

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        public void deleteItemCart()
        {
            click(deleteItem);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Assert.IsTrue(elementAppears(emptyCart));
        }

        public string setPrice(string value)
        {
            string newPrice = getText(cartPrice);
            newPrice = formatPrice(newPrice, ".");
            comparePrice(value, newPrice);

            value = newPrice;
            return value;
        }
    }
}
