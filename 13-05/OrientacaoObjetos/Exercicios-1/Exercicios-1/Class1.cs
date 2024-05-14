using System;

public class Produto
{
	//Declaração das variáveis membros
	private string nome;
	private float preco;
	private int quantidade;

	//Construtor com 2 parâmetros sobrecarregados
	public Produto(string n, float p)
	{
		nome = n;
		preco = p;
		quantidade = 0;
	}
	public Produto(string n, float p, int q)
	{
		nome = n;
		preco = p;
		quantidade = q;
	}
	//Método setter (void, já que não retorna nada)
	public void setNome(string n)
	{
		nome = n;
	}
	//Método getter
	public string getNome()
	{
		return nome;
	}
    //Método para a variável preço
    public void setPreco(float p)
    {
        preco = p;
    }
	public float getPreco()
	{
		return preco;
	}
    public void setQuantidade(int q)
    {
        quantidade = q;
    }
    public int getQuantidade()
    {
        return quantidade;
    }
	public float valorTotalProd()
	{
		return preco * quantidade;
	}
}
