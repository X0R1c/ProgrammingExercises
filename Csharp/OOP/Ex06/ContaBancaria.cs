using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06 {
    class ContaBancaria {
        public string Titular;
        public double Saldo = 0.0;

        public double Depositar(double valor) {
            return Saldo += valor;
        }
        public double Sacar(double valor) {
            return Saldo -= valor;
        }
        public void ExibirSaldo() {
            Console.WriteLine($"R$ {Saldo}");
        }
    }
}
