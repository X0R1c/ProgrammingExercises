using System;

class Ex12{
    static void Main(){
        int segundos,minutos,horas;
        Console.Write("Segundos:");
        segundos = Convert.ToInt32(Console.ReadLine());
        horas = segundos / 3600;
        resto = segundos % 3600;
        minutos = (resto) / 60;
        segundos = (resto) % 60;
        Console.WriteLine($"{horas.ToString("00")}:{minutos.ToString("00")}:{segundos.ToString("00")}");
    }
}