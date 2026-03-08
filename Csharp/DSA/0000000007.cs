using System;

class Ex07
{
    static void Main()
    {
        Console.Write("Número:"); decimal x = Convert.ToDecimal(Console.ReadLine());
        if (x % 2 == 0){
            Console.WriteLine("Par");
        }
        else{
            Console.WriteLine("ímpar");
        }
    }
}