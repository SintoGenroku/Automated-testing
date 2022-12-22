using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    public class ComputerMonitorsPage
    {
        private IWebDriver _driver;

        private const string BASE_URL = "https://www.samsung.com/ru/monitors/all-monitors/";

        private IWebElement _priceButton => _driver.FindElement(By.XPath("/html/body/div[5]/div[5]/div[2]/div[2]/div/div/div[1]/div[2]/div[1]/div[2]/button"));

        private IWebElement _acceptPrice => _driver.FindElement(By.XPath("/html/body/div[5]/div[5]/div[2]/div[2]/div/div/div[1]/div[2]/div[1]/div[2]/div/ul/li[2]/button/div/label/input"));

        public ComputerMonitorsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }

        public void SortByPrice()
        {
            _priceButton.Click();
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _acceptPrice.Click();
        }
    }
}
