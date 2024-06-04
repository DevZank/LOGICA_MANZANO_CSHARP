using System;

class ExercicioA
{
    static void Main (string[] args)
    {
        Console.Write("Escreva uma Temperatura em ºC: ");
        double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

        double temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

        Console.WriteLine($"{temperaturaCelsius}ºC convertido em Fahrenheit é: {temperaturaFahrenheit}ºF");
    }
}