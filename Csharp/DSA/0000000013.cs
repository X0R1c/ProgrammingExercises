using System;

class Ex13 {
    static void Main() {
        Console.Write("Altura:");
        double altura = Console.ReadLine();
        Console.Write("Peso:");
        double peso = Console.ReadLine();
        double imc = peso / (altura * altura);
        Console.Write($"IMC:{imc.ToString("0.00")}");
    }
}