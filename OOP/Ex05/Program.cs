using Ex05;
using System;
using System.Globalization;

namespace Exercicio05 {
    class Ex05 {
        static void Main(String[] args) {
            Retangulo r1;
            r1 = new Retangulo();
            Console.WriteLine("CALCULADORA DE RETÂNGULO");
            Console.Write("Largura:");
            r1.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura:");
            r1.Altura = double.Parse(Console.ReadLine());
            double area = r1.CalcularArea(), perimetro = r1.CalcularPerimetro();
            Console.WriteLine($"Área:{area}");
            Console.WriteLine($"Perimetro:{perimetro}");
        }
    }
}