/* 
  Efetuar a leitura de quatro números inteiros e apresentar os números que são divisíveis por 2 e 3. 
*/

using System;

class ExercioG
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o Primeiro numero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o Segundo numero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o Terceiro numero: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o Quarto numero: ");
        double numero4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Numeros Divisiveis por 2 e 3: ");

        if (numero1 % 2 == 0 && numero1 % 3 == 0)
        {
            Console.WriteLine(numero1);
        }
        if (numero2 % 2 == 0 && numero2 % 3 == 0)
        {
            Console.WriteLine(numero2);
        }
        if (numero3 % 2 == 0 && numero3 % 3 == 0)
        {
            Console.WriteLine(numero3);
        }
        if (numero4 % 2 == 0 && numero4 % 3 == 0)
        {
            Console.WriteLine(numero4);
        }
    }
}