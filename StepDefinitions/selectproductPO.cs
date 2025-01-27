namespace MyNamespace
{
    [Binding]
    public class SelectProductPO
    {
        public readonly ScenarioContext _scenarioContext;
        private IWebDriver driver;
        
        public SelectProductPO(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"que acesso a página inicial da loja PO")]
        public void DadoQueAcessoAPaginaInicialDaLojaPO()
        {
            _scenarioContext.Pending();
        }

        [When(@"preencho o ""(.*)"" PO")]
        public void QuandoPreenchoOPO(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"a ""(.*)"" e clico no botao login PO")]
        public void QuandoAEClicoNoBotaoLoginPO(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe ""(.*)"" no titulo da Selecao PO")]
        public void EntaoExibeNoTituloDaSelecaoPO(string products0)
        {
            _scenarioContext.Pending();
        }
        [When(@"adiciono o ""(.*)"" ao carrinho PO")]
        public void QuandoAdicionoOAoCarrinhoPO(string p0)
        {
            _scenarioContext.Pending();
        }
        [When(@"clico no icone do carrinho de compras PO")]
        public void QuandoClicoNoIconeDoCarrinhoDeComprasPO()
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe a página do carrinho com a ""(.*)"" PO")]
        public void EntaoExibeAPaginaDoCarrinhoComAPO(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"nome do ""(.*)"" PO")]
        public void EntaoNomeDoPO(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o preco como ""(.*)"" PO")]
        public void EntaoOPrecoComoPO(string p0)
        {
            _scenarioContext.Pending();
        }
    }
}