using System;

public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal faz um som");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au-au");
    }
}

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau-miau");
    }
}
