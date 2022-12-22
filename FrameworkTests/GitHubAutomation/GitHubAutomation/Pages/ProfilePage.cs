using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    public class ProfilePage
    {
        private IWebDriver _driver;

        private const string BASE_URL = "https://account.samsung.com/membership/contents/profile/profile-gate?state=TNcNMIUfQBAemCpxruNjJCyHWWOXdnkT&paramLocale=ru_BY";

        

        private IWebElement _fieldEdit => _driver.FindElement(By.XPath("/html/body/div[5]/div[5]/div/div[1]/div[1]/div[1]/a"));

        private IWebElement _nameEdit => _driver.FindElement(By.XPath("/html/body/div[5]/div[4]/div/div/div/div[2]/form/div[1]/div[1]/input"));

        private IWebElement _acceptButton => _driver.FindElement(By.XPath("/html/body/div[5]/div[4]/div/div/div/div[2]/form/div[4]/div[1]/button"));

        public ProfilePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ChangeNameProfile(string name)
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _fieldEdit.Click();
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _nameEdit.SendKeys(name);
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            _acceptButton.Click();
        }
    }
}
