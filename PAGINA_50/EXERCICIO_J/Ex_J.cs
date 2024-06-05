/*
  Elaborar um programa que apresente o resultado inteiro da divisão de dois números quaisquer.
  Para a elaboração do programa, não utilizar em hipótese alguma o conceito do operador aritmético
  DIV. A solução deve ser alcançada com a utilização de looping. Ou seja, o programa deve
  apresentar como resultado (quociente) quantas vezes o divisor cabe no dividendo. 
*/

using System;

class ExercicioJ
{
    static void Main(string[] args)
    {
        double dividendo;
        double divisor;
        double quociente = 0;

        Console.WriteLine("Escreva um número: ");
        dividendo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escreva outro número: ");
        divisor = Convert.ToDouble(Console.ReadLine());

        do
        {
            dividendo -= divisor;
            quociente++;
        } while (dividendo > divisor);

        Console.WriteLine($"O Resultado da divisão é {quociente + 1}");
    }
}