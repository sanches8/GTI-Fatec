float peso, altura, total;

Console.WriteLine("Insira o seu peso: ");
peso = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Insira a sua altura: ");
altura = Convert.ToSingle(Console.ReadLine());

total = peso / (altura * altura);

if (total <= 18.5)
{
    Console.WriteLine("Abaixo do peso normal");
}
else if (total <= 24.9)
{
    Console.WriteLine("Peso normal");
}

else if (total <= 29.9)
{
    Console.WriteLine("Excesso de peso");
}

else if (total <= 34.9)
{
    Console.WriteLine("Obesidade classe I");
}

else if (total <= 39.9)
{
    Console.WriteLine("Obesidade classe II");
}

else
{
    Console.WriteLine("Obesidade classe III");
}
tem menu de contextonsole.WriteLine("Obesidade classe 3");
}

/* 
 float peso, altura, total;
 
Console.WriteLine("Insira o seu peso: ");
peso = Convert.ToSingle(Console.ReadLine());
 
Console.WriteLine("Insira a sua altura: ");
altura = Convert.ToSingle(Console.ReadLine());
 
total = peso / (altura * altura);
 
if (total <= 18.5)
{
    Console.WriteLine("Abaixo do peso normal");
}
 
else if (total <= 24.9)
{
    Console.WriteLine("Peso normal");
}
 
else if (total <= 29.9)
{
    Console.WriteLine("Excesso de peso");
}
 
else if (total <= 34.9)
{
    Console.WriteLine("Obesidade classe I");
}
 
else if (total <= 39.9)
{
    Console.WriteLine("Obesidade classe II");
}
 
else
{
    Console.WriteLine("Obesidade classe III");
}
tem menu de contexto
 */