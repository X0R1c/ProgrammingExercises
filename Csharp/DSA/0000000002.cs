using System;

class Ex02
{
    static void Main()
    {
        int n1, n2;
        Console.Write("Digite o primeiroe número:"); n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número:"); n2 = Convert.ToInt32(Console.ReadLine());
        int soma = n1 + n2;
        Console.WriteLine($"A soma entre {n1} + {n2} é: {soma}");
    }
}