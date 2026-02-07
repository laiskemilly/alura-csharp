Produto produto1 = new Produto();
produto1.Nome = "Notebook";
produto1.Marca = "Dell";
produto1.Valor = 4000;
produto1.Estoque = 23;

Produto produto2 = new Produto();
produto2.Nome = "Ipad";
produto2.Marca = "Apple";
produto2.Valor = 5000;
produto2.Estoque = 0;

Console.WriteLine(produto1.InfoProduto);
Console.WriteLine("\n" + produto2.InfoProduto);
