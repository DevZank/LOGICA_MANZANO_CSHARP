/*
  Elaborar um programa que apresente como resultado o valor de uma potência de uma base
  qualquer elevada a um expoente qualquer, ou seja, de BE, em que B é o valor da base e E o valor
  do expoente. Observe que neste exercício não pode ser utilizado o operador de exponenciação do
  portuguol (^). 
*/

using System;

class ExercioF
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o Valor da base: ");
        int baseA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o Valor do Expoente: ");
        int expoente = Convert.ToInt32(Console.ReadLine());

        double resultado = 1;
        double contadora = 1;

        while (contadora <= expoente)
        {
            resultado *= baseA;
            contadora++;
        }

        Console.WriteLine($"O resultado de {baseA} elevado a {expoente} é: {resultado}");
    }
}