using Ex03;
using System;
using System.Globalization;

namespace Exercicio {
    class Ex03 {
        static void Main(String[] args) {
            Pessoa p1;
            p1 = new Pessoa();

            Console.Write("Digite seu nome:");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite sua idade:");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura:");
            p1.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            p1.Apresentar();
        }
    }
}