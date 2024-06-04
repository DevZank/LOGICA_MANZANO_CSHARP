using System;

class ExercicioF
{
    static void Main (string[] args)
    {
        Console.WriteLine("Escreva o valor de A: ");
        string valorA = Console.ReadLine();

        Console.WriteLine("Escreva o valor de B: ");
        string valorB = Console.ReadLine();

        string troca = valorA;
        valorA = valorB;
        valorB = troca;

        Console.WriteLine($"O valor de A, agora é {valorA}");
        Console.WriteLine($"O valor de B, agora é {valorB}");
    }    
}