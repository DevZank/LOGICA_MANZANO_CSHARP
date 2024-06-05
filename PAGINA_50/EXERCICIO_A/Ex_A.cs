/*
  Apresentar os quadrados dos números inteiros de 15 a 200. 
*/

using System;

class ExercicioA
{
    static void Main(string[] args)
    {
        int numero = 15;

        do
        {
            Console.WriteLine(numero * numero);

            numero++;
        } while (numero < 201);
    }
}