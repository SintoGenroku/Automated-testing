using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace GitHubAutomation.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;

        private const string BASE_URL = "https://www.samsung.com/ru/";

       private IWebElement _acceptCookiesButton => _driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        
        private IWebElement _searchField => _driver.FindElement(By.XPath("/html/body/div[5]/header/div[1]/div/div[2]/div/div[2]/div/div[1]/div[1]/form/input"));

        private IWebElement _searchItem => _driver.FindElement(By.XPath("/html/body/div[5]/header/div[1]/div/div[2]/div/div[2]/div/div[1]/div[1]/form/span/svg"));

        private IWebElement _sortElemets => _driver.FindElement(By.XPath("/html/body/div[5]/div[5]/div[2]/div[1]/div/div/div[2]/div/div/div/select"));

        private IWebElement _priceSort => _driver.FindElement(By.XPath("/html/body/div[5]/div[5]/div[2]/div[1]/div/div/div[2]/div/div/div/select/option[4]"));

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }

        public void AcceptAllCookies()
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _acceptCookiesButton.Click();
        }

        
        public void SearchPhones(string phoneModel)
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _searchField.SendKeys(phoneModel);
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _searchItem.Click();
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _sortElemets.Click();
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _priceSort.Click();
        }
    }
}
