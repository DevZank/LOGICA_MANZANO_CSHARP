using System;

class ExercioL
{
    static void Main(string[] args)
    {
        double valorAnt = -1;
        double valor;
        double valorMaior;
        double valorMenor;
        double verificacao = 1;

        while (verificacao == 0)
        {
            Console.WriteLine("Escreva um valor: ");
            valor = Convert.ToDouble(Console.ReadLine());

            if (valor < 0)
            {
                verificacao = 1;
            }

            if (valor > valorAnt)
            {
                valorMaior = valor;
            }

            if (valor < valorAnt)
            {
                valorMenor = valor;
            }

            valorAnt = valor;
        }

        Console.WriteLine($"O Maior valor digitado foi: {valorMaior}");
        Console.WriteLine($"O Menor valor digitado foi: {valorMenor}");
    }
}