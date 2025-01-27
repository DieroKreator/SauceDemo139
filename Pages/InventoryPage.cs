
namespace Pages
{
    public class InventoryPage : CommonPage
    {
        // Mapeamento de elementos
        // Como queremos mapear o botão "Add to Cart" e o id muda por produto
        // Iremos mapear de forma dinâmica pelo bloco de Ações

        // Constructor
         public InventoryPage(IWebDriver driver) : base(driver){}

        // Métodos ou ações
        public void AdicionarAoCarrinho(string produto)
        {
            String seletorProduto = "add-to-cart-" + produto.ToLower().Replace(" ", "_");
            driver.FindElement(By.Id(seletorProduto)).Click();
        }

        public void RemoveFromCart(string itemName)
        {
            var item = _driver.FindElement(By.XPath($"//div[text()='{itemName}']/following-sibling::button"));
            item.Click();
        }

        public void GoToCart()
        {
            var cartButton = _driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
            cartButton.Click();
        }
    }
}