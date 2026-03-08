using System;

class Ex04
{
    static void Main()
    {
        Console.Write("Escreva a temperatura em celsius:");
        double c = Convert.ToDouble(Console.ReadLine().Replace(".",","));
        double f = (c * 9/5) + 32;
        Console.Write($"Temperatura em Fahrenheit:{f.ToString("0.00")}");
    }
}