/*
  Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um número qualquer. 
*/

using System;

class ExercioA
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um Valor: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int contadora = 1;
        int resultado = 0;

        while (contadora < 11)
        {
            resultado = numero * contadora;

            Console.WriteLine($"{numero} * {contadora} = {resultado}");

            contadora++;
        }
    }
}