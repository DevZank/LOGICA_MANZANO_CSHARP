/* 
    Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um número qualquer. 
*/

using System;

class ExercicioB
{
    static void Main(string[] args)
    {
        double valor = 0;
        int contador = 1;

        Console.Write("Digite um valor: ");
        valor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("--------------");

        for (int contadora = 1; contadora < 11; contadora++)
        {
            Console.WriteLine($"{valor} x {contadora} = {valor * contadora}");
        }
        Console.WriteLine("--------------");
    }
}