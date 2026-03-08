using System;

class Ex15
{
    static void Main()
    {
        Console.Write("Nome Produto:");
        var produto = Console.ReadLine();
        Console.Write("Valor Unitário:");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantidade:");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        var subtotal = valor * Convert.ToDouble(quantidade);
        var desconto = (subtotal > 200) ? subtotal * 0.90 : subtotal;
        Console.WriteLine($"Valor total: R$ {desconto.ToString("0.00")}");
    }
}