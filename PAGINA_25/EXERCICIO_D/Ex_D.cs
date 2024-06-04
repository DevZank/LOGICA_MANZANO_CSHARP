using System;

class ExercicioD
{
    static void Main (string[] args)
    {
        Console.WriteLine("Qual o tempo gasto da Viagem? ");
        int tempo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual a Velocidade média que foi utilizada? ");
        double velocidade = Convert.ToDouble(Console.ReadLine());

        double distancia = tempo * velocidade;
        double litros_usados = distancia / 12;

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Nesta Viagem, o tempo gasto foi de: {tempo}h");
        Console.WriteLine($"A Velocidade média foi de: {velocidade}km/h");
        Console.WriteLine($"A distância foi de: {distancia}km");
        Console.WriteLine($"A quantidade de litros gastos foi de: {Math.Round(litros_usados, 2)}L");
        Console.WriteLine("--------------------------------------------");
    }
}