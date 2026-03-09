using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05 {
    class Retangulo {
        public double Largura;
        public double Altura;
        public double CalcularArea() {
            return Altura * Largura; 
        }
        public double CalcularPerimetro() {
            return 2.0 * (Altura + Largura);
        }
    }
}
