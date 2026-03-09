using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04a {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double CalcularValorTotal() {
            double valor_resulta = (double)Quantidade * Preco;
            return valor_resulta;
        }
    }
}

