using OpenQA.Selenium;

namespace SauceDemo139.Pages
{
    public class CommonPage
    {
        protected IWebDriver driver;

        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
        