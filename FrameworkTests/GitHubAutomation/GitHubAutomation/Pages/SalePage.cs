using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    public class SalePage
    {
        private IWebDriver _driver;

        private const string BASE_URL = "https://www.samsung.com/ru/shop/offers/";

        private IWebElement _firstDeviceInListButton => _driver.FindElement(By.XPath("//*[@id=\"product-search-results\"]/div[2]/div[4]/div/div[3]/div[1]/div[1]/div/div/div"));

        public SalePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
            Console.WriteLine("Sale Page opened");
        }

        public void OpenProductPage()
        {
            _firstDeviceInListButton.Click();
        }
    }
}
