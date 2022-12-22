using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    public class ProductPage
    {
        private IWebDriver _driver;

        private IWebElement _likeProduct => _driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div[3]/div[2]/div[2]/div/div[11]/div/div[3]/div/button"));

        private IWebElement _basketProduct => _driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div[3]/div[2]/div[2]/div/div[11]/div/div[2]/button"));

        private IWebElement _viewProduct => _driver.FindElement(By.XPath("/html/body/div[14]/div/div/div/div/div[3]/div[1]/a"));

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void AddingProductInFavourite()
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _likeProduct.Click();
        }

        public void AddingProductInBasket()
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _basketProduct.Click();
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(60));
            _viewProduct.Click();
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(60));
        }

    }
}
