using System;

class Ex10{
    static Void Main(){
        Console.Write("Escreva uma palavra/frase:");
        var frase = Console.ReadLine();
        Console.WriteLine(frase.ToUpper());
        Console.WriteLine(frase.ToLower());
        Console.WriteLine(frase.Trim());
    }
}