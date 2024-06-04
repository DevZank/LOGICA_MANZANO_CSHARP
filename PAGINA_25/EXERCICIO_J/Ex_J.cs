using System;

class ExercicioJ
{
    static void Main (string[] args)
    {
        Console.Write("Insira a quantidade de dolares: ");
        double quantidadeDolar = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual o valor da cotação do dolar hoje: ");
        double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

        double valorReal = quantidadeDolar * cotacaoDolar;

        Console.WriteLine($"O valor da transformação é R${valorReal}")
    }    
}