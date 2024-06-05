/* 
    Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de
    1 até 500. 
*/

using System;

class ExercicioD
{
    static void Main(string[] args)
    {
        int soma = 0;

        for (int contadora = 1; contadora <= 500; contadora++)
        {
            if (contadora % 2 == 0)
            {
                soma += contadora;
            }
        }

        Console.WriteLine($"A soma dos 500 primeiros números pares inteiros é: {soma}");
    }
}