using OpenQA.Selenium;
using Pages;
using TechTalk.SpecFlow;

namespace MyNamespace
{
    [Binding]
    public class SelectProductPO
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver driver;

        private LoginPage loginPage;
        private CommonPage commonPage;
        private InventoryPage inventoryPage;
        private CartPage cartPage;

        public SelectProductPO(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            driver = (IWebDriver)_scenarioContext["driver"];
        }

        [Given(@"que acesso a página inicial da loja PO")]
        public void DadoQueAcessoAPaginaInicialDaLojaPO()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"preencho o ""(.*)"" PO")]
        public void QuandoPreenchoOPO(string usuario)
        {
            loginPage = new LoginPage(driver);
            loginPage.PreencherUsuario(usuario);
        }

        [When(@"a ""(.*)"" e clico no botao login PO")]
        public void QuandoAEClicoNoBotaoLoginPO(string senha)
        {
            loginPage.PreencherSenha(senha);
            loginPage.ClicarNoBotaoLogin();
        }

        [Then(@"exibe ""(.*)"" no titulo da Selecao PO")]
        public void EntaoExibeNoTituloDaSelecaoPO(string tituloSecao)
        {
            inventoryPage = new InventoryPage(driver);
            Assert.That(inventoryPage.LerTituloDaSecao, 
                        Is.EqualTo(tituloSecao));
        }

        [When(@"adiciono o ""(.*)"" ao carrinho PO")]
        public void QuandoAdicionoOAoCarrinhoPO(string produto)
        {
            inventoryPage.AdicionarAoCarrinho(produto);
        }

        [When(@"clico no icone do carrinho de compras PO")]
        public void QuandoClicoNoIconeDoCarrinhoDeComprasPO()
        {
            inventoryPage.IrParaCarrinho();
        }

        [Then(@"exibe a página do carrinho com a ""(.*)"" PO")]
        public void EntaoExibeAPaginaDoCarrinhoComAPO(string quantidade)
        {
            cartPage = new CartPage(driver);
            Assert.That(cartPage.LerQuantidade(),
                        Is.EqualTo(quantidade));
        }

        [Then(@"nome do ""(.*)"" PO")]
        public void EntaoNomeDoPO(string produto)
        {
            Assert.That(cartPage.LerTituloProduto(),
                        Is.EqualTo(produto));
        }

        [Then(@"o preco como ""(.*)"" PO")]
        public void EntaoOPrecoComoPO(string preco)
        {
            Assert.That(cartPage.LerPreco(),
                        Is.EqualTo(preco));
        }
    }
}