namespace Exercicio {
    class Ex04 {
        static void Main(String[] args) {
            int numfuc = Convert.ToInt32(Console.ReadLine()), hrtrabalhadas = Convert.ToInt32(Console.ReadLine());
            double valorphora = Convert.ToDouble(Console.ReadLine()), salario =  (double) hrtrabalhadas * valorphora;
            Console.WriteLine($"NUMBER: {numfuc}");
            Console.WriteLine($"SALARY: U$ {salario.ToString("F2")}");
        }
    }
}
