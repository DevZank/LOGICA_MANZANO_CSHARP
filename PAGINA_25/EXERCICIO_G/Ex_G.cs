using System;

class ExercicioG
{
    static void Main (string[] args)
    {
        Console.Write("Digite o valor de A: ");
        int valorA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int valorB = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        int valorC = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de D: ");
        int valorD = Convert.ToInt32(Console.ReadLine());

        int soma1 = valorA + valorB;
        int soma2 = valorA + valorC;
        int soma3 = valorA + valorD;
        int soma4 = valorB + valorC;
        int soma5 = valorB + valorD;
        int soma6 = valorC + valorD;
        int produto1 = valorA * valorB;
        int produto2 = valorA * valorC;
        int produto3 = valorA * valorD;
        int produto4 = valorB * valorC;
        int produto5 = valorB * valorD;
        int produto6 = valorC * valorD;

        Console.WriteLine($"O resultado das somas foram: {soma1}, {soma2}, {soma3}, {soma4}, {soma5}, {soma6}");
        Console.WriteLine($"O resultado dos produtos foram: {produto1}, {produto2}, {produto3}, {produto4}, {produto5}, {produto6}");
    } 
}