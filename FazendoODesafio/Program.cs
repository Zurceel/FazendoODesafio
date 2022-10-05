using Supermerca;

Console.WriteLine("Bem vindo ao Supermercado Menor preço!");

GerenciamentoProdutos produto = new GerenciamentoProdutos
{
	nomeproduto = "Chocolate Diamente Negro",
	fabricante = "Nestlé",
	codigobarras = 8361000000220994004,
	valorunitario = 4.99,
	valorcompra = 5.000,
	emestoque = 150
};

Console.WriteLine("O produto é: " + produto.nomeproduto);
Console.WriteLine("O fabricante é: " + produto.fabricante);
Console.WriteLine("O códido de barras é: " + produto.codigobarras);
Console.WriteLine("O valor para compra unitário é é: " + produto.valorunitario);
Console.WriteLine("O valor comprado foi: " + produto.valorcompra);
Console.WriteLine("Temos em estoque : " + produto.emestoque);

Console.ReadKey();