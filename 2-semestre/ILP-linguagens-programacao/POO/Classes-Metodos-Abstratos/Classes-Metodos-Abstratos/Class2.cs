using System;

//Classe abstrata
abstract class Forma
{
	private string Nome;

	public Forma(string nome)
	{
		this.Nome;
	}
	public string GetNome()
	{
		return this.Nome;
	}
	public void SetNome(string nome)
	{
		this.Nome = nome;
	}
	public abstract double CalcularArea();
}
class Circulo: Forma
{
	private double Raio;
	//Esse base("Circulo") invoca o construtor da classe de base.
	public Circulo(double raio): base("Circulo")
	{
		this.Raio = raio;
	}
    public double getRaio(double raio)
    {
        return Raio;
    }
    public void setRaio(double raio)
	{
            this.Raio = raio;
    }
}