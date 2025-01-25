
namespace Pages
{
    public class InventoryPage : CommonPage
    {
        // Mapeamento de elementos

        // Constructor
         public InventoryPage(IWebDriver driver) : base(driver){}

        // Métodos ou ações
        public void AddToCart(string itemName)
        {
            var item = _driver.FindElement(By.XPath($"//div[text()='{itemName}']/following-sibling::button"));
            item.Click();
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