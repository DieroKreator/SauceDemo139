using OpenQA.Selenium;

namespace SauceDemo139.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        // Locators
        private readonly By _usernameField = By.Id("user-name");
        private readonly By _passwordField = By.Id("password");
        private readonly By _loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Methods
        public void EnterUsername(string username)
        {
            _driver.FindElement(_usernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(_passwordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(_loginButton).Click();
        }

        public bool IsLoginButtonDisplayed()
        {
            return _driver.FindElement(_loginButton).Displayed;
        }
    }
}