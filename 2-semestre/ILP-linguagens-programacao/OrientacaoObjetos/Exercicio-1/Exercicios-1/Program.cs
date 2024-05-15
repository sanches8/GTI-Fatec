class Program
{
    static void Main(string[] args)
    {
        // Criação de instâncias da classe Produto usando diferentes construtores
        Produto produto1 = new Produto("Camisa", 25.99f);
        Produto produto2 = new Produto("Calça", 39.99f, 10);

        // Acessando métodos getters para obter informações sobre os produtos
        Console.WriteLine("Produto 1:");
        Console.WriteLine("Nome: " + produto1.getNome());
        Console.WriteLine("Preço: " + produto1.getPreco());
        Console.WriteLine("Quantidade: " + produto1.getQuantidade());
        Console.WriteLine("Quantidade: " + produto2.valorTotalProd());

        Console.WriteLine("\nProduto 2:");
        Console.WriteLine("Nome: " + produto2.getNome());
        Console.WriteLine("Preço: " + produto2.getPreco());
        Console.WriteLine("Quantidade: " + produto2.getQuantidade());
        Console.WriteLine("Quantidade: " + produto2.valorTotalProd());
    }
}