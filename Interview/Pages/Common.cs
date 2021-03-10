using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Utils
{
    abstract class Common
    {
        public IWebDriver driver { get; set; }

        public Common()
        {
            this.driver = driver;
        }

        public bool elementAppears(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void click(IWebElement element)
        {
            element.Click();
        }

        public void sendKeys(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public string getText(IWebElement element)
        {
            string text = element.Text;
            return text;
        }
        
        public void comparePrice(string firstValue, string secondValue)
        {
            Assert.IsTrue(firstValue.Equals(secondValue));
        }

        public string formatPrice(string value, string splitValue)
        {
            string[] newValue = value.Split(splitValue);
            return newValue[0];
        }
        
    }
}
