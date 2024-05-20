using System;

public class Produto
{
    private string Nome;
    private float Preco;
    private int Quantidade;

    // Método construtor
    public Produto(string nome = "Lucas", float preco = 0.0f, int quantidade = 0)
    {
        this.Nome = nome;
        this.Preco = preco;
        Quantidade = quantidade;
    }

    public Produto(string nome, float preco)
    {
        this.Nome = nome;
        this.Preco = preco;
        Quantidade = 0; // Assuming default quantity is 0
    }

    public void SetNome(string nome)
    {
        this.Nome = nome;
    }

    public string GetNome()
    {
        return this.Nome;
    }

    public void SetPreco(float preco)
    {
        this.Preco = preco;
    }

    public float GetPreco()
    {
        return this.Preco;
    }

    public void SetQuantidade(int quantidade)
    {
        this.Quantidade = quantidade;
    }

    public int GetQuantidade()
    {
        return this.Quantidade;
    }

    public float CalculaValorEmEstoque()
    {
        return this.Quantidade * this.Preco;
    }
}
