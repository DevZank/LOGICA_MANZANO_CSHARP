/*
  Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa 
  de 1 até 500.
*/

using System;

class ExercioC
{
    static void Main(string[] args)
    {
        int contadora = 1;
        int soma = 0;

        while (contadora < 501)
        {
            if (contadora % 2 == 0)
            {
                soma += contadora;
                Console.WriteLine(contadora);
            }
            contadora++;
        }

        Console.WriteLine($"A soma dos números pares entre 1 a 500 é {soma}");
    }
}