using System;

class ExercicioC
{
    static void Main (string[] args)
    {
        Console.WriteLine("Digite o Raio da Lata: ");
        double raioLata = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a Altura da Lata: ");
        double alturaLata = Convert.ToDouble(Console.ReadLine());

        double volumeLata =  3.14 * Math.Pow(raioLata, 2) * alturaLata;

        Console.WriteLine($"O Volume da Lata é: {volumeLata}");
    }
}