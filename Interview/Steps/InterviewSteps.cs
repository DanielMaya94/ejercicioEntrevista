using Interview.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Interview.Steps
{
    [Binding]
    public sealed class InterviewSteps
    {
        private IWebDriver driver;
        private string value;

        public InterviewSteps(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"I enter amazon page")]
        public void GivenIEnterAmazonPage()
        {
            //driver.Url = ConfigurationManager.AppSettings["Amazon"];
            driver.Url = "https://www.amazon.com";
        }

        [Given(@"I search for '(.*)'")]
        public void GivenISearchFor(string search)
        {
            LandingPage lp = new LandingPage(driver);
            lp.search(search);
        }
        
        [Given(@"I click Sign in button")]
        public void GivenIClickSignInButton()
        {
            LandingPage lp = new LandingPage(driver);
            lp.clickSignUp();
        }
        
        [When(@"I click in the first result")]
        public void WhenIClickInTheFirstResult()
        {
            ResultsPage rp = new ResultsPage(driver);
            rp.verifyResultsAppear();
            value = rp.setPrice(value);
            rp.selectFirstResult();
        }
        
        [Then(@"I compare prices and add to cart")]
        public void WhenIAddToCart()
        {
            DetailsPage dp = new DetailsPage(driver);
            dp.setPrice(value);
            dp.addItemToCart();
        }
        
        
        [When(@"I fill name and email fields")]
        public void WhenIFillNameAndEmailFields()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I locate search bar and search for Echo")]
        public void WhenILocateSearchBarAndSearchForEcho()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I go to cart and verify price")]
        public void ThenIGoToCartAndVeryPrice()
        {
            PreviewPage pp = new PreviewPage(driver);
            pp.clickGoToCart();
            CartPage cp = new CartPage(driver);
            cp.setPrice(value);
        }
        
        [Then(@"I delete the item")]
        public void ThenIDeleteTheItem()
        {
            CartPage cp = new CartPage(driver);
            cp.deleteItemCart();
        }
        
        [Then(@"I click star right here option")]
        public void ThenIClickStarRightHereOption()
        {
            SignUpPage sp = new SignUpPage(driver);
            sp.registerAccount();
        }
        
        [Then(@"I click on condition of use link")]
        public void ThenIClickOnConditionOfUseLink()
        {
            RegisterPage rp = new RegisterPage(driver);
            rp.clickConditionsOfUse();
        }
        
        [Then(@"I click Echo support")]
        public void ThenIClickEchoSupport()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I verify Getting started, Wi-Fi and bluetooth, Device Software and hardware, Troubleshooting elements are present")]
        public void ThenIVerifyGettingStartedWi_FiAndBluetoothDeviceSoftwareAndHardwareTroubleshootingElementsArePresent()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
