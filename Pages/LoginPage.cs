using OpenQA.Selenium;

namespace SauceDemo139.Pages
{
    public class LoginPage : CommonPage
    {
        private IWebElement txtUsuario => _driver.FindElement(By.Id("user-name"));
        private IWebElement txtSenha => _driver.FindElement(By.Id("password"));
        private IWebElement btnLogin => _driver.FindElement(By.Id("login-button"));

        public LoginPage(IWebDriver driver) : base(driver){}

        // Methods
        public void PreencherUsuarioESenha(string usuario, string senha)
        {
            txtUsuario.SendKeys(usuario);
            txtSenha.SendKeys(senha);
        }

        public void ClicarNoBotaoLogin()
        {
            btnLogin.Click();
        }

        public void DarEnter()
        {
            txtSenha.SendKeys(Keys.Enter);
        }
    }
}