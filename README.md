O FormProduto cuida dos campos e da validação, de forma que pode ser reutilizado em páginas com listas diferentes.
Quando os dados são válidos, ele envia o produto cadastrado pelo `EventCallback<Produto>` `AoCadastrar`.
A página Produtos.razor recebe esse aviso no método AdicionarProduto, inclui o item na sua lista e a tabela é atualizada.
