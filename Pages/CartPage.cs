using OpenQA.Selenium;

namespace Pages
{
    public class CartPage : CommonPage
    {
        private IWebElement lblQuantidade => driver.FindElement(By.CssSelector("div.cart-quantity"));
        private IWebElement lblNomeProduto => driver.FindElement(By.CssSelector("div.inventory_item_name"));
        private IWebElement lblPreco => driver.FindElement(By.CssSelector("div.inventory_item_price"));

        public CartPage(IWebDriver driver) : base(driver){}

        public String LerQuantidade()
        {
            return lblQuantidade.Text;
        }
        public String LerTituloProduto()
        {
            return lblNomeProduto.Text;
        }   
        public String LerPreco()
        {
            return lblPreco.Text;
        }
    }
}