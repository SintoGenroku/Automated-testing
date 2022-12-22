using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace GitHubAutomation.Pages
{
    public class FavouritePage
    {
        private IWebDriver _driver;

        private const string BASE_URL = "https://www.samsung.com/ru//Wishlist-Show";

        private IWebElement _deletProduct => _driver.FindElement(By.XPath("/html/body/div[5]/div[4]/div[1]/div/div/div/div[1]/div[2]/div[1]/div[2]/div[2]/div/a[2]"));

        private IWebElement _acceptToDelete => _driver.FindElement(By.XPath("/html/body/div[5]/div[4]/div[2]/div/div/div[3]/button[2]"));

        public FavouritePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }

        public void DeleteProductInFavouriteList()
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _deletProduct.Click();
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _acceptToDelete.Click();
        }
    }
}
