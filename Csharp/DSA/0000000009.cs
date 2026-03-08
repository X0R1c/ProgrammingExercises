using System;

class ex09
{
    static void Main()
    {
        Console.Write("Escreve uma frase:");
        var frase = Console.ReadLine();
        Console.WriteLine(@$"Tamanho da frase/string: {frase.Length}");
    }
}