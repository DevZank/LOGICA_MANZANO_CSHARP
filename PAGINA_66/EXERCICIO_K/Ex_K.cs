/* 
    Elaborar um programa que apresente como resultado o valor do fatorial dos valores ímpares
    situados na faixa numérica de 1 a 10.
*/

using System;

class ExercicioK
{
    static void Main(string[] args)
    {
        int resultado = 1;

        for (int contadora = 1; contadora <= 10; contadora++)
        {
            if (contadora % 2 != 0)
            {
                for (int controladora = 1; controladora <= contadora; controladora++)
                {
                    resultado *= contadora;
                }

                Console.WriteLine($"{controladora}! = {resultado}");
                resultado = 1;
            }
        }
    }
}