using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03 {
    class Pessoa {
        public string Nome;
        public int Idade;
        public double Altura;
    public void Apresentar() {
        Console.WriteLine("Dados:");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Altura: {Altura}");
        }
    }
}
