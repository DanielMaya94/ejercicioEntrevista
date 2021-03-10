using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Utils
{
    public static class Driver
    {
        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The webBrowser is not initialized");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static void startBrowser()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("disable-infobars");
            browser = new ChromeDriver(chromeOptions);
        }

        public static void stopBrowser()
        {
            browser.Quit();
        }

    }
}
