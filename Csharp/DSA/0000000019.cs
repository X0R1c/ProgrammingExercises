namespace Exercicio {
    class Ex03 {
        static void Main(String[] args) {
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()), c = Convert.ToInt32(Console.ReadLine()), d = Convert.ToInt32(Console.ReadLine()), diferenca = a * b - c * d;
            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
