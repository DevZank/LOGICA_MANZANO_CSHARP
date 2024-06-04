using System;

class ExercicioE
{
    static void Main (string[] args)
    {
        Console.WriteLine("Qual o valor das prestações? ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual a quantidade de dias atrasados? ");
        int tempo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual a taxa de Juros? ");
        double taxa = Convert.ToDouble(Console.ReadLine());

        double total = valor + valor * taxa / 100 * tempo;

        Console.WriteLine("");
        Console.WriteLine($"O valor final da prestação é R${total}");
    }
}