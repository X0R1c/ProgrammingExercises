using Ex04a;
using System;
using System.Globalization;

namespace Ex04 {
    class Ex04 {
        static void Main(String[] args) {
            Produto prod1;
            prod1 = new Produto();

            Console.Write("Nome Produto:");
            prod1.Nome = Console.ReadLine();
            Console.Write("Preço:");
            prod1.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade:");
            prod1.Quantidade = int.Parse(Console.ReadLine());
            double valortotal = prod1.CalcularValorTotal();
            Console.WriteLine($"Valor total: R$ {valortotal.ToString("F2")}");
        }
    }
}