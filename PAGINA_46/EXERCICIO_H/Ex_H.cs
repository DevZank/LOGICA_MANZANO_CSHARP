/*
  Elaborar um programa que apresente os valores de conversão de graus Celsius em Fahrenheit, de
  10 em 10 graus, iniciando a contagem em 10 graus Celsius e finalizando em 100 graus Celsius. O
  programa deve apresentar os valores das duas temperaturas. A fórmula de conversão
  é F = 9*C + 160 / 5, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.
*/

using System;

class ExercioH
{
    static void Main(string[] args)
    {
        int celsius = 10;
        int fahrenheit = 0;

        while (celsius <= 100)
        {
            fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine($"O valor em Celsius é {celsius}ºC e o valor em Fahrenheit é: {fahrenheit}ºF");
            celsius += 10;
        }
    }
}