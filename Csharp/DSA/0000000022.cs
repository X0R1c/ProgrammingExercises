using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(String[] args) {
            Console.WriteLine("Entre com as medidas do triângulo de X:");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area_triangulo_x = calculaarea(a, b, c);

            Console.WriteLine("Entre com as medidas do triângulo de Y:");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area_triangulo_y = calculaarea(a, b, c);
            
            Console.WriteLine($"Área de X: {area_triangulo_x.ToString("F4")}");
            Console.WriteLine($"Área de Y: {area_triangulo_y.ToString("F4")}");
            if (area_triangulo_x > area_triangulo_y) {          
                Console.WriteLine("Maior área: X");
            }
            if (area_triangulo_x < area_triangulo_y) {
                Console.WriteLine("Maior área: Y");
            }
        }
        static double calculaarea(double a, double b, double c) {
            double p = (double) (a + b + c) / 2.0;
            double arearesulta = (double) Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return arearesulta;
        }
    }
}
