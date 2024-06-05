/* 
  Efetuar a leitura de um valor inteiro positivo ou negativo e apresentar o número lido como sendo um
  valor positivo, ou seja, o programa deverá apresentar o módulo de um número fornecido. Lembre-se
  de verificar se o número fornecido é menor que zero; sendo, multiplique-o por -1. 
*/

using System;

class ExercioB
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor: ");
        int lerValor = Convert.ToInt32(Console.ReadLine());

        if (lerValor < 0)
        {
            lerValor *= -1;
        }

        Console.WriteLine($"O valor sendo Positivo é: {lerValor}");
    }
}