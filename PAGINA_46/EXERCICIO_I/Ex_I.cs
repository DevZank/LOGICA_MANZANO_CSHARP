using System;

class ExercioI
{
    static void Main(string[] args)
    {
        double numero = 0;
        double media = 0;
        double soma = 0;
        double contadora = 0;

        while (contadora < 10)
        {
            Console.WriteLine($"Digite um numero ({contadora + 1} de 10):");
            numero = Convert.ToDouble(Console.ReadLine());

            soma += numero;
            contadora++;
        }

        media = soma / 10;

        Console.WriteLine($"O total da Soma é: {soma}");
        Console.WriteLine($"O total da Média é: {media}");
    }
}