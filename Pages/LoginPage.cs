using OpenQA.Selenium;

namespace Pages
{
    public class LoginPage : CommonPage
    {
        private IWebElement txtUsuario => driver.FindElement(By.Id("user-name"));
        private IWebElement txtSenha => driver.FindElement(By.Id("password"));
        private IWebElement btnLogin => driver.FindElement(By.Id("login-button"));

        public LoginPage(IWebDriver driver) : base(driver){}

        // Methods
        public void PreencherUsuarioESenha(string usuario, string senha)
        {
            txtUsuario.SendKeys(usuario);
            txtSenha.SendKeys(senha);
        }

        public void PreencherUsuario(string usuario)
        {
            txtUsuario.SendKeys(usuario);
        }

        public void PreencherSenha(string senha)
        {
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