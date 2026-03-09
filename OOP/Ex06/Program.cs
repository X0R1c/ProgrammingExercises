using Ex06;
using System;
using System.Globalization;

namespace Exercicio06 {
    class Ex06 {
        public static void Main(String[] args) {
            ContaBancaria pessoa1;
            pessoa1 = new ContaBancaria();
            pessoa1.ExibirSaldo();
            pessoa1.Depositar(50);
            pessoa1.ExibirSaldo();
            pessoa1.Sacar(25);
            pessoa1.ExibirSaldo();
            pessoa1.Depositar(70);
            pessoa1.ExibirSaldo();
        }
    }     
}