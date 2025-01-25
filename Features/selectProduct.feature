# language: pt
Funcionalidade: Selecionar Produto na Loja

  @Loja
  Cenario: Selecao de produto com sucesso
    Dado que acesso a página inicial da loja
    Quando preencho o usuário como "standard_user"
    E a senha "secret_sauce" e clico no botao login
    Entao exibe "Products" no titulo da Selecao
    Quando adiciono o produto "Sauce Labs Backpack" ao carrinho
    E clico no icone do carrinho de compras
    Entao exibe a página do carrinho com a quantidade "1"
    E nome do produto "Sauce Labs Backpack"
    E o preco como "$29.99"

  Esquema do Cenario: Selecao de produto com sucesso DDT
    Dado que acesso a página inicial da loja
    Quando preencho o <usuario>
    E a <senha> e clico no botao login
    Entao exibe <tituloSecao> no titulo da Selecao
    Quando adiciono o <produto> ao carrinho
    E clico no icone do carrinho de compras
    Entao exibe a página do carrinho com a <quantidade>
    E nome do <produto>
    E o preco como <preco>

    Exemplos:
      | usuario         | senha          | tituloSecao | produto                 | quantidade | preco    |
      | "standard_user" | "secret_sauce" | "Products"  | "Sauce Labs Backpack"   | "1"        | "$29.99" |
      | "visual_user"   | "secret_sauce" | "Products"  | "Sauce Labs Bike Light" | "1"        | "$9.99"  |
