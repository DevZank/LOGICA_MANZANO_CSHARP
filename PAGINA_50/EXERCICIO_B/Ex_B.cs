/*
  Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de
  1 até 500. 
*/

using System;

class ExercicioB
{
    static void Main(string[] args)
    {
        int numero = 1;
        int soma = 0;

        do
        {
            if (numero % 2 == 0)
            {
                soma += numero;
            }

            numero++;
        } while (numero < 501);

        Console.WriteLine($"A soma dos numeros pares é: {soma}");
    }
}