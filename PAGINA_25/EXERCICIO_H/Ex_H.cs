using System;

class ExercicioH
{
    static void Main (string[] args)
    {
        Console.Write("Digite o comprimento da caixa: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a largura da caixa: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura da caixa: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double volume = comprimento * largura * altura;

        Console.WriteLine($"O volume desta caixa retangular é de: {volume}!");
    }    
}