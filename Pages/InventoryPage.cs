
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
    }
}