using Produto_interface;

//instancia do nosso objeto da classe carrinho
Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "Call of Duty", 480f);
Produto p2 = new Produto(2, "Celeste", 22f);
Produto p3 = new Produto(3, "The Last of Us", 150f);

//adicionar
carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

//listar
carrinho.Listar();

//total
carrinho.ValorTotal();

//remover
carrinho.Remover(p1);
Console.WriteLine($"=============================");

//listar
carrinho.Listar();
//total
carrinho.ValorTotal();
Console.WriteLine($"=============================");

//atualizar
Produto produtoAtualizado = new Produto();
produtoAtualizado.Nome = "Afterimage";
produtoAtualizado.Preco = 68f;
carrinho.Atualizar(2, produtoAtualizado);

carrinho.Listar();
carrinho.ValorTotal();