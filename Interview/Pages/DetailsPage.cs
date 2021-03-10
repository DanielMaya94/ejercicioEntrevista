using Interview.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Pages
{
    class DetailsPage : Common, Interface
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[@id='price_inside_buybox']")]
        [CacheLookup]
        protected IWebElement detailsPrice { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        [CacheLookup]
        protected IWebElement addToCart { get; set; }

        public DetailsPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        public void addItemToCart()
        {
            click(addToCart);
        }

        public string setPrice(string value)
        {
            string newPrice = getText(detailsPrice);
            newPrice = formatPrice(newPrice, ".");
            comparePrice(value, newPrice);

            value = newPrice;
            return value;
        }
    }
}
