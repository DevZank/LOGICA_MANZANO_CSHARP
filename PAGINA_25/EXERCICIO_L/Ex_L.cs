using System;

class ExercicioL
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A: ");
        double valorA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        double valorB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de C: ");
        double valorC = Convert.ToDouble(Console.ReadLine());

        double soma = Math.Pow(valorA, 2) + Math.Pow(valorB, 2) + Math.Pow(valorC, 2);

        Console.WriteLine($"A soma dos quadrados dos três valores é: {soma}");
    }
}