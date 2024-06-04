using System;

abstract class Midia
{
    private string Titulo;
    private int Ano;

    public Midia(string titulo, int ano)
    {
        this.Titulo = titulo;
        this.Ano = ano;
    }
    public string GetTitulo()
    {
        return Titulo;
    }
    public void SetTitulo(string titulo)
    {
        Titulo = titulo;
    }
    public int GetAno()
    {
        return Ano;
    }
    public void SetAno(int ano)
    {
        Ano = ano;
    }
    public abstract void MostrarInformacao();
}

public class Livro : Midia
{
    private string AutorPrincipal;
    private int NumeroPaginas;

    public Livro(string titulo, int ano, string autorPrincipal, int numeroPaginas) : base(titulo, ano)
    {
        AutorPrincipal = autorPrincipal;
        NumeroPaginas = numeroPaginas;
    }
    public string GetAutorPrincipal()
    {
        return AutorPrincipal;
    }
    public void SetAutorPrincipal(string autorPrincipal)
    {
        AutorPrincipal = autorPrincipal;
    }
    public int GetNumeroPaginas()
    {
        return NumeroPaginas;
    }
    public void SetNumeroPaginas(int numeroPaginas)
    {
        NumeroPaginas = numeroPaginas;
    }
    public override void MostrarInformacao()
    {
        Console.WriteLine("O livro com titulo " + this.GetTitulo() + " que é de autoria de " + this.GetAutorPrincipal() + " foi publicado em " + this.GetAno() + " e tem " + this.GetNumeroPaginas() + " páginas ");
    }
}

public class DVD : Midia
{
    private int NumeroFaixas;

    public DVD(string titulo, int ano, int numeroFaixas) : base(titulo, ano)
    {
        NumeroFaixas = numeroFaixas;
    }
    public int GetNumeroFaixas()
    {
        return NumeroFaixas;
    }
    public void SetNumeroFaixas(int numeroFaixas)
    {
        NumeroFaixas = numeroFaixas;
    }
    public override void MostrarInformacao()
    {
        Console.WriteLine("O DVD de titulo " + this.GetTitulo() + " foi gravado no ano de " + this.GetAno() + " e tem " + this.GetNumeroFaixas() + " faixas ");
    }
}

public class Revista : Midia
{
    public Revista(string titulo, int ano) : base(titulo, ano)
    {
    }
    public override void MostrarInformacao()
    {
        Console.WriteLine("A revista de titulo " + this.GetTitulo() + " foi lançada no ano de " + this.GetAno());
    }
}

