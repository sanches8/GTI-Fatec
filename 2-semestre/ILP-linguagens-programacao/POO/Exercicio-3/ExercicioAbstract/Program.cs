cclass Program
{
    static void Main(string[] args)
{
    // Criando instâncias de Livro, DVD e Revista
    Livro livro = new Livro("Aprendendo C#", 2022, "João da Silva", 300);
    DVD dvd = new DVD("Filme X", 2020, 20);
    Revista revista = new Revista("Revista Y", 2023);

    // Mostrando informações
    Console.WriteLine("Informações do Livro:");
    livro.MostrarInformacao();

    Console.WriteLine("\nInformações do DVD:");
    dvd.MostrarInformacao();

    Console.WriteLine("\nInformações da Revista:");
    revista.MostrarInformacao();

    Console.ReadKey(); // Aguarda pressionar uma tecla para fechar o console
}
}

