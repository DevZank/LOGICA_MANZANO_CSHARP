/*
  Elaborar um programa que efetue a leitura de valores positivos inteiros até que um valor negativo
  seja informado. Ao final devem ser apresentados o maior e o menor valores informados pelo
  usuário.
*/

using System;

class ExercicioI
{
    static void Main(string[] args)
    {
        double total = 0;
        int quantidadeValores = 0;
        double maior = 0;
        double menor = 0;
        double valor;

        do
        {
            Console.WriteLine("Digite um valor: ");
            valor = Convert.ToDouble(Console.ReadLine());

            if (quantidadeValores == 0)
            {
                maior = valor;
                menor = valor;
            }
            else if (valor > maior)
            {
                maior = valor;
            }
            else if (valor < menor)
            {
                menor = valor;
            }

            if (valor >= 0)
            {
                total += valor;
                quantidadeValores++;
            }
        } while (valor >= 0);

        Console.WriteLine($"O maior valor foi: {maior}");
        Console.WriteLine($"O menor valor foi: {menor}");
    }
}