using System;

class ExercicioM
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A: ");
        double valorA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        double valorB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de C: ");
        double valorC = Convert.ToDouble(Console.ReadLine());

        double quadrado = (valorA + valorB + valorC) * (valorA + valorB + valorC);

        Console.WriteLine($"O quadrados da soma dos três valores é: {quadrado}");
    }
}