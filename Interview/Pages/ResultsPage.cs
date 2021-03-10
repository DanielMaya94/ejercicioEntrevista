using Interview.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Pages
{
    class ResultsPage : Common, Interface
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@data-index='0'][contains(@class,'result')]//img")]
        [CacheLookup]
        private IWebElement firstResult { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Note 20')]")]
        [CacheLookup]
        private IWebElement searchedItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-index='0'][contains(@class,'result')]//span[@class='a-price']")]
        [CacheLookup]
        private IWebElement listPrice { get; set; }

        public ResultsPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        public void verifyResultsAppear()
        {
            Assert.IsTrue(elementAppears(searchedItem));
        }

        public void selectFirstResult()
        {
            click(firstResult);
        }

        public string setPrice(string value)
        {
            value = getText(listPrice);
            value = formatPrice(value, "\r\n");
            return value;
        }
    }
}
