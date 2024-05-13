using System;

public class Aluno
{
    //Método construtores (estabelece as bases)
    public Aluno(string n)
    {
        nome = n;
    }
    //Método setNome: colcoa valor no atributo nome (set para setar uma info)
    public void setNome(string n)
    {
        nome = n;
    }
    //Método get: retorna algo, no caso o nome do aluno
    public string getNome()
    {
        return nome;
    }
}
