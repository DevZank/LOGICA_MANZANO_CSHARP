/* 
  Elaborar um programa que efetue a leitura de um determinado valor inteiro, e efetue a sua
  apresentação, caso o valor não seja maior que três.
*/

using System;

class ExercioK
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero <= 3)
        {
            Console.WriteLine($"Apresentando o Numero {numero}");
        }
    }
}