using System;

class Ex11
{
    static void Main()
    {
        Console.Write("Nome:");
        var nome = Console.ReadLine();
        Console.Write("Salário Bruto:");
        double salario = Convert.ToDouble(Console.ReadLine());
        Console.Write("Desconto:");
        double desconto = Convert.ToDouble(Console.ReadLine());
        double salarioliquido = salario - (salario * desconto / 100);
        Console.WriteLine($"Funcionário: {nome} - Salário Liquído: {salarioliquido}");
    }
}