namespace Exercicio {
    class Ex02 {
        static void Main(String[] args) {
            double r = Convert.ToDouble(Console.ReadLine()), pi = 3.14159, area = pi * (r*r);
            Console.WriteLine($"A= {area.ToString("F4")}");
        }
    }
}
