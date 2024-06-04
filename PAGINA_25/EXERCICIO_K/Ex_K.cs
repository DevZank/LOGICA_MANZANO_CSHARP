using System;

class ExercicioK
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a quantidade de reais que você tem: ");
        double quantidadeReal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual o valor da cotação do dolar hoje: ");
        double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

        double valorDolar = quantidadeReal / cotacaoDolar;

        Console.WriteLine($"O valor da transformação é U${valorDolar}");
    }
}