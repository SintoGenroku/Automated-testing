using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    public class LoginPage
    {
        private const string BASE_URL = "https://account.samsung.com/accounts/v1/MBR/signInGate?locale=ru_BY&countryCode=BY&goBackURL=https:%2F%2Faccount.samsung.com%2Fmembership%2Fintro&returnURL=https:%2F%2Faccount.samsung.com%2Fmembership%2Fintro&redirect_uri=https:%2F%2Faccount.samsung.com%2Fmbr-svc%2Fauth%2FregistAuthentication&tokenType=OAUTH&response_type=code&client_id=ea2r064y73&state=gfyPfjVzDTjbbWWxovGvwKstpGiDyaPD";

        private IWebElement _acceptCookiesButton => driver.FindElement(By.XPath("/html/body/div[11]/div[2]/div/div[1]/div/div[2]/div/button[2]"));

        private IWebElement inputLogin => driver.FindElement(By.XPath("/html/body/div[5]/div[4]/div/div/div/div/div/div/div/div[1]/form/div[1]/div[1]/input"));

        private IWebElement inputPassword => driver.FindElement(By.XPath("/html/body/div[5]/div[4]/div/div/div/div/div/div/div/div[1]/form/div[1]/div[1]/input"));

        private IWebElement buttonSubmit => driver.FindElement(By.XPath("/html/body/div[5]/div[4]/div/div/div/div/div/div/div/div[1]/form/div[3]/button"));
        
        private IWebElement linkLoggedInUser;

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Console.WriteLine("Login Page opened");
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(180));
            _acceptCookiesButton.Click();
        }

        public void Login(string username, string password)
        {
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            inputLogin.SendKeys(username);
            buttonSubmit.Click();
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
            inputPassword.SendKeys(password);
            buttonSubmit.Click();
        }
    }
}
