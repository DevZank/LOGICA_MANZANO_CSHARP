/* 
  Efetuar a leitura de três valores (variáveis A, B e C) e efetuar o cálculo da equação completa de
  segundo grau, apresentando as duas raízes, se para os valores informados for possível efetuar o
  referido cálculo. Lembre-se de que a variável A deve ser diferente de zero. 
*/

using System;

class ExercioF
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A: ");
        double valorA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        double valorB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de C: ");
        double valorC = Convert.ToDouble(Console.ReadLine());

        double variavelDeAjuste = 0;

        if (valorA > valorB)
        {
            variavelDeAjuste = valorA;
            valorA = valorB;
            valorB = variavelDeAjuste;
        }

        if (valorB > valorC)
        {
            variavelDeAjuste = valorB;
            valorB = valorC;
            valorC = variavelDeAjuste;
        }

        if (valorA > valorB)
        {
            variavelDeAjuste = valorA;
            valorA = valorB;
            valorB = variavelDeAjuste;
        }

        Console.WriteLine($"Os valores em ordem crescente são: {valorA}, {valorB}, {valorC}");
    }
}