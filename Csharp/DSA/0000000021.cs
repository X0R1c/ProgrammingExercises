namespace Exercicio {
    class Ex05 {
        static void Main(String[] args) {
            int prod1num = Convert.ToInt32(Console.ReadLine()), prod1qnt = Convert.ToInt32(Console.ReadLine());
            double prod1val = Convert.ToDouble(Console.ReadLine());
            int prod2num = Convert.ToInt32(Console.ReadLine()), prod2qnt = Convert.ToInt32(Console.ReadLine());
            double prod2val = Convert.ToDouble(Console.ReadLine());
            double valorpagar = (double) (prod1qnt * prod1val) + (prod2qnt * prod2val);
            Console.WriteLine($"VALOR A PAGAR: R$ {valorpagar.ToString("F2")}");
        }
    }
}
