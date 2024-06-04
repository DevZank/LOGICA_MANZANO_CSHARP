using System;

class ExercicioI
{
    static void Main (string[] args)
    {
        Console.Write("Digite o valor de A: ");
        int valorA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int valorB = Convert.ToInt32(Console.ReadLine());

        int diferenca = 0;
        int resultado = 0;

        if (valorA > valorB) {
            diferenca = valorA - valorB;
        } else {
            diferenca = valorB - valorA;
        }

        resultado = diferenca * diferenca;

        Console.WriteLine($"O quadradp da diferença dos Valores é: {resultado}");
    }    
}