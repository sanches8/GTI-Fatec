using System;
using System.Collections.Generic;

// Classe base Produto
class Produto
{
    // Propriedades Nome e Preco com getters e setters
    public string Nome { get; set; }
    public double Preco { get; set; }

    // Construtor que recebe valores para Nome e Preco
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    // Método MostrarDetalhes() genérico
    public virtual void MostrarDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}, Preço: R${Preco:F2}");
    }
}

// Subclasse Eletronico
class Eletronico : Produto
{
    // Construtor que recebe valores para Nome e Preco
    public Eletronico(string nome, double preco) : base(nome, preco)
    {
    }

    // Implementação específica de MostrarDetalhes() para Eletronico
    public override void MostrarDetalhes()
    {
        Console.WriteLine($"Produto Eletrônico: {Nome}, Preço: R${Preco:F2}");
    }
}

// Subclasse Vestuario
class Vestuario : Produto
{
    // Construtor que recebe valores para Nome e Preco
    public Vestuario(string nome, double preco) : base(nome, preco)
    {
    }

    // Implementação específica de MostrarDetalhes() para Vestuario
    public override void MostrarDetalhes()
    {
        Console.WriteLine($"Produto de Vestuário: {Nome}, Preço: R${Preco:F2}");
    }
}

// Subclasse Alimento
class Alimento : Produto
{
    // Construtor que recebe valores para Nome e Preco
    public Alimento(string nome, double preco) : base(nome, preco)
    {
    }

    // Implementação específica de MostrarDetalhes() para Alimento
    public override void MostrarDetalhes()
    {
        Console.WriteLine($"Produto Alimentício: {Nome}, Preço: R${Preco:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma lista de Produto
        List<Produto> produtos = new List<Produto>();

        // Adicionando objetos das subclasses à lista
        produtos.Add(new Eletronico("Smartphone", 1500));
        produtos.Add(new Vestuario("Camiseta", 29.99));
        produtos.Add(new Alimento("Arroz", 5.99));

        // Iterando pela lista e chamando o método MostrarDetalhes() para cada objeto
        foreach (var produto in produtos)
        {
            produto.MostrarDetalhes();
        }
    }
}
