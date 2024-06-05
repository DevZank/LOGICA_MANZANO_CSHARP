/*
  Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4+...+98+99+100).
*/

using System;

class ExercioB
{
    static void Main(string[] args)
    {
        int contadora = 1;
        int soma = 0;

        while (contadora <= 100)
        {
            soma += contadora;
            contadora++;
        }

        Console.WriteLine($"A soma dos cem primeiros números inteiros (1+2+3+4...99+100) = {soma}");
    }
}