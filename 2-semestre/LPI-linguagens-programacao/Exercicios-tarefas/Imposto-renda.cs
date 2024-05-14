double redmen;

Console.WriteLine("Insira a sua renda mensal: ");
redmen = Convert.ToSingle(Console.ReadLine());

if (redmen <= 2112)
{
    Console.WriteLine("Isento");
}

else if (redmen <= 2826.65)
{
    Console.WriteLine("A aquilota a ser aplicada é de 7,5%. Parcela de deduzir: R$158,40");
}

else if (redmen <= 3751.05)
{
    Console.WriteLine("A aquilota a ser aplicada é de 15%. Parcela de deduzir: R$370,40");
}

else if (redmen <= 4664.68)
{
    Console.WriteLine("A aquilota a ser aplicada é de 22,5%. Parcela de deduzir: R$651,73");
}