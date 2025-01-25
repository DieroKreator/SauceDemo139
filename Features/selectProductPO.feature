# language: pt
Funcionalidade: Selecionar Produto na Loja PO
  @PO
  Esquema do Cenario: Selecao de Produto com Sucesso PO 
    Dado que acesso a página inicial da loja PO 
    Quando preencho o <usuario> PO 
    E a <senha> e clico no botao login PO 
    Entao exibe <tituloSecao> no titulo da Selecao PO 
    Quando adiciono o <produto> ao carrinho PO 
    E clico no icone do carrinho de compras PO 
    Entao exibe a página do carrinho com a <quantidade> PO 
    E nome do <produto> PO 
    E o preco como <preco> PO 

    Exemplos:
      | usuario         | senha          | tituloSecao | produto                 | quantidade | preco    |
      | "standard_user" | "secret_sauce" | "Products"  | "Sauce Labs Backpack"   | "1"        | "$29.99" |
      | "visual_user"   | "secret_sauce" | "Products"  | "Sauce Labs Bike Light" | "1"        | "$9.99"  |
