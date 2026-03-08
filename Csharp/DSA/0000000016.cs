using System;
using System.Globalization;

namespace GeradorEmail {
    class GeraEmail {
        static void Main(String[] args) {
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome:");
            string sobrenome = Console.ReadLine();
            Console.Write("Empresa:");
            string empresa = Console.ReadLine();
            string emailcorporativo = nome.ToLower() + "." + sobrenome.ToLower() + "@" + empresa.ToLower() + ".com";
            Console.WriteLine(emailcorporativo);
        }
    }
}
