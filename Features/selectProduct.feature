#language: pt
Funcionalidade: Selecionar produto na loja

  Cenário: Selecao de produto com sucesso
    Dado que acesso a pagina inicial da loja
    Quando preencho o usuario como "standard_user"
    E a senha "sauce_secret" e clico no botao login
    Então exibe "Products" no titulo da Selecao
    Quando adiciono o produto "Sauce Labs Backpack" ao carrinho
    E clico no icone do carrinho de compras
    Então exibe a pagina do carrinho com a quantidade "1"
    E nome do produto "Sauce Labs Backpack"
    E o preco como "29.99"