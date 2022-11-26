using OpenQA.Selenium;
using WebDriverTests.Pages.Bases;

namespace WebDriverTests.Pages;

public class SamsungLoginPage : BasePage
{
    private const string _login = "el.mail212@gmail.com";
    private const string _password = "90rUYdfKLUpLYze90";

    public IWebElement LogInButton => _wait.Until(_driver => _driver.FindElement(By.CssSelector(".main-header__btn.btn.btn--black.p-open")));

    public IWebElement LoginInput => _wait.Until(_driver => _driver.FindElement(By.Id("input-log-in1")));

    public IWebElement PassordInput => _wait.Until(_driver => _driver.FindElement(By.Id("input-log-in2")));

    public SamsungLoginPage(IWebDriver driver) : base(driver)
    {
    }
    
    public void OpenLoginWindow()
    {
        LogInButton.Click();
    }

    public void InputLogin()
    {
        LoginInput.SendKeys(_login);
    }

    public void InputPasswordAndConfirm()
    {
        PassordInput.SendKeys(_password + Keys.Enter);
    }
}