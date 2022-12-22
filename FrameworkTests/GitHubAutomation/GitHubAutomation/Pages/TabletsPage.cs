using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    public class TabletsPage
    {
        private IWebDriver _driver;

        private const string BASE_URL = "https://www.samsung.com/ru/tablets/?product1=sm-t875nzkaser&product2=sm-t735nzkaser&product3=sm-t225nzaaser";

        private IWebElement _tabletFirstInListButton => _driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div/div/div/div/div[1]/div/div[1]/a/div[1]/picture/img"));

        public TabletsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }

        public void OpenProductPage()
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _tabletFirstInListButton.Click();
        }
    }
}
