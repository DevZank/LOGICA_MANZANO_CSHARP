/* 
  Elaborar um programa que efetue a leitura de um número inteiro e apresentar uma mensagem
  informando se o número é par ou ímpar. 
*/

using System;

class ExercioI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um Número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O NUMERO É PAR!");
        }
        else
        {
            Console.WriteLine("O NUMERO É IMPAR!");
        }
    }
}