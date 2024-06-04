using System;

class ExercicioB
{
    static void Main (string[] args)
    {
        Console.Write("Escreva uma Temperatura em ºF: ");
        double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

        double temperaturaCelsius = (temperaturaFahrenheit - 32) / 1.8;

        Console.WriteLine($"{temperaturaFahrenheit}ºF convertido para Celsius é: {temperaturaCelsius}ºC");
    }
}