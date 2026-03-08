using System;

class Ex14{
    static void Main(){
        Console.Write("Escreva seu nome:");
        var nomecompleto = Console.ReadLine();
        string[] nomes = nomecompleto.Split(' ');
        var inititals = string.Join(".",nomes.Select(word => word.first()));
        Console.WriteLine(initials);
    }
}