/* 
  Ler dois valores numéricos inteiros e apresentar o resultado da diferença do maior pelo menor valor.
*/

using System;

class ExercioA
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero inteiro: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro numero inteiro: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int diferenca = 0;

        if (numero1 <= 0 || numero2 <= 0)
        {
            Console.WriteLine("Os valores digitados são Invalidos");
        }
        else if (numero1 > numero2)
        {
            diferenca = numero1 - numero2;
        }
        else
        {
            diferenca = numero2 - numero1;
        }

        Console.WriteLine($"O maior numero digitado é {Math.Max(numero1, numero2)} e o menor numero digitado é: {Math.Min(numero1, numero2)}");
        Console.WriteLine($"A diferença entre eles da {diferenca}");
    }
}