/*
  Elaborar um programa que apresente como resultado o valor do fatorial dos valores ímpares
  situados na faixa numérica de 1 a 10.
*/

using System;

class ExercicioG
{
    static void Main(string[] args)
    {
        int contadora = 1;

        do
        {
            int fatorial = 1;
            int atual = contadora;

            do
            {
                fatorial *= atual;
                atual--;
            } while (atual > 0);

            Console.WriteLine($"Fatorial de {contadora} = {fatorial}");

            contadora += 2;
        } while (contadora <= 10);
    }
}