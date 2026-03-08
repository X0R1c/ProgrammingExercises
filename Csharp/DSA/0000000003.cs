using System;

class Ex03
{
    static void Main()
    {
        double nota1,nota2,media;
        Console.Write("Nota 1:");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nota 2:");
        nota2 = Convert.ToDouble(Console.ReadLine());
        media = (nota1 + nota2) / 2;
        Console.WriteLine($"Media: {media.ToString("0.00")}");
    }
}