/* 
    Apresentar os quadrados dos números inteiros de 15 a 200.
*/

using System;

class ExercicioA
{
    static void Main(string[] args)
    {
        int resultado = 0;

        for (int contadora = 15; contadora < 201; contadora++)
        {
            resultado = contadora * contadora;
            Console.WriteLine($"{contadora}² = {resultado}");
        }
    }
}