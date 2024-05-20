string NomeProd;
float PrecoProd;
int QuantProd;

Console.WriteLine("Forneça o nome do primeiro produto: ");
NomeProd = Console.ReadLine();
Console.WriteLine("Forneça o preço do primeiro produto: ");
PrecoProd = float.Parse(Console.ReadLine());
Console.WriteLine("Forneça a quantidade em estoque do primeiro produto: ");
QuantProd = int.Parse(Console.ReadLine());  

Produto P1 = new Produto(NomeProd, PrecoProd, QuantProd);

Console.WriteLine("Forneça o nome do segundo produto: ");
NomeProd = Console.ReadLine();
Console.WriteLine("Forneça o preço do segundo produto: ");
PrecoProd = float.Parse(Console.ReadLine());
Console.WriteLine("Forneça a quantidade em estoque do segundo produto: ");
QuantProd = int.Parse(Console.ReadLine());

Produto P2 = new Produto(NomeProd, PrecoProd, QuantProd);

Console.WriteLine("O produto " + P1.GetNome() + " cujo preço é R$ " + P1.GetPreco() + " possui um estoque de " + P1.GetQuantidade() + P1.CalculaValorEmEstoque() + " em valor estocado ");
Console.WriteLine("O produto " + P2.GetNome() + " cujo preço é R$ " + P2.GetPreco() + " possui um estoque de " + P2.GetQuantidade() + P2.CalculaValorEmEstoque() + " em valor estocado ");