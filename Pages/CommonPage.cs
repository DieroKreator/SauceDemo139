using OpenQA.Selenium;

namespace Pages
{
    public class CommonPage
    {
        // Atributos
        protected IWebDriver driver;

        // Mapeamento dos Elementos comuns a duas ou mais páginas
        private IWebElement lblTituloSecao => driver.FindElement(By.CSSSelector("span.title"));
        private IWebElement iconCarrinho => driver.FindElement(By.CssSelector("a.shopping_cart_link"));

        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
        