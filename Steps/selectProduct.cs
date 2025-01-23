using System;
using TechTalk.SpecFlow;

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
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Given(@"que acesso a pagina inicial da loja")]
        public void DadoQueAcessoAPaginaInicialDaLoja()
        {
            _scenarioContext.Pending();
        }

        [When(@"preencho o usuario como ""(.*)""")]
        public void QuandoPreenchoOUsuarioComo(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"a senha ""(.*)"" e clico no botao login")]
        public void QuandoASenhaEClicoNoBotaoLogin(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe ""(.*)"" no titulo da Selecao")]
        public void EntaoExibeNoTituloDaSelecao(string products)
        {
            _scenarioContext.Pending();
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void QuandoAdicionoOProdutoAoCarrinho(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"clico no icone do carrinho de compras")]
        public void QuandoClicoNoIconeDoCarrinhoDeCompras()
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)""")]
        public void EntaoExibeAPaginaDoCarrinhoComAQuantidade(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"nome do produto ""(.*)""")]
        public void EntaoNomeDoProduto(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o preco como ""(.*)""")]
        public void EntaoOPrecoComo(string p0)
        {
            _scenarioContext.Pending();
        }
    }
}