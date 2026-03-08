using System;

class Ex08
{
    static void Main()
    {
        Console.Write("Nome:");
        var nome = Console.ReadLine();
        Console.Write("Sobrenome:");
        var sobrenome = Console.ReadLine();
        var nomecompleto = nome + " " + sobrenome;
        Console.WriteLine($"Seu nome completo é: {nomecompleto}");
    }
}