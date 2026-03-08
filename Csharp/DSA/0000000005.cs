using System;

class Ex05
{
    static void Main()
    {
        Console.Write("Escreva um numero:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Os numeros digitalizados foram: {n1} e {n2}");
        Console.WriteLine($"Soma: {n1+n2}");
        Console.WriteLine($"Diferença: {n1-n2}");
        Console.WriteLine($"Multiplicacao: {n1*n2}");
        Console.WriteLine($"Divisão: {Convert.ToDecimal(n1/n2)}");
        Console.WriteLine($"Resto: {Convert.ToDecimal(n1/n2)}");
    }
}