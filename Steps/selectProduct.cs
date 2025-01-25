using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyNamespace
{
    [Binding]
    public class Steps
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver;

        public Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"que acesso a pagina inicial da loja")]
        public void DadoQueAcessoAPaginaInicialDaLoja()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        [When(@"preencho o usuario como ""(.*)""")]
        public void QuandoPreenchoOUsuarioComo(string username)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
        }

        [When(@"a senha ""(.*)"" e clico no botao login")]
        public void QuandoASenhaEClicoNoBotaoLogin(string password)
        {
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void QuandoAdicionoOProdutoAoCarrinho(string product)
        {
            String productSelector = "add-to-cart-" + product.ToLower().Replace(" ", "-");
            Console.WriteLine($"Seletor de Produto = {productSelector}");  
            driver.FindElement(By.Id(productSelector)).Click();
        }

        [When(@"clico no icone do carrinho de compras")]
        public void QuandoClicoNoIconeDoCarrinhoDeCompras()
        {
            driver.FindElement(By.Id("shopping_cart_container14")).Click();
        }

        [Then(@"exibe ""(.*)"" no titulo da Selecao")]
        public void EntaoExibeNoTituloDaSelecao(string title)
        {
            // WaitForElement(driver, By.CssSelector("span.title"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(3000));
            wait.Until(d => driver.FindElement(By.CssSelector("span.title")).Displayed);
            Assert.That(driver.FindElement(By.CssSelector("span.title")).Text, Is.EqualTo(title));
        }

        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)""")]
        public void EntaoExibeAPaginaDoCarrinhoComAQuantidade(string quantity)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.cart_quantity")).Text, Is.EqualTo(quantity));
        }

        [Then(@"nome do produto ""(.*)""")]
        public void EntaoNomeDoProduto(string product)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.inventory_item_name")).Text, 
                                           Is.EqualTo(product));
        }

        [Then(@"o preco como ""(.*)""")]
        public void EntaoOPrecoComo(string price)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.inventory_item_price")).Text, 
                                           Is.EqualTo(price));
        }
    }
}