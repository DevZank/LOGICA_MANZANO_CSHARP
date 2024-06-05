/*
  Elaborar um programa que efetue a leitura de 15 valores numéricos inteiros e no final apresente o
  total do somatório da fatorial de cada valor lido. 
*/

using System;

class ExercicioE
{
    static void Main(string[] args)
    {
        int numeroBase = 0;
        int numeroDoFatorial = 0;
        int totalDoFatorial = 0;
        int somaDosFatoriais = 0;

        do
        {
            Console.WriteLine("Escreva um número: ");
            numeroDoFatorial = Convert.ToInt32(Console.ReadLine());

            totalDoFatorial = 1;

            do
            {
                totalDoFatorial *= numeroDoFatorial;
                numeroDoFatorial--;
            } while (numeroDoFatorial >= 1);

            Console.WriteLine($"Total do Fatorial: {totalDoFatorial}");

            somaDosFatoriais += totalDoFatorial;

            numeroBase++;
        } while (numeroBase < 16);

        Console.WriteLine($"Total de todos Fatoriais é: ${somaDosFatoriais}");
    }
}