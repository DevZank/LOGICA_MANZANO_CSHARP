/*
  Elaborar um programa que efetue a leitura sucessiva de valores numéricos e apresente no final o
  total do somatório, a média aritmética e o total de valores lidos. O programa deve fazer as leituras
  dos valores enquanto o usuário estiver fornecendo valores positivos. Ou seja, o programa deve
  parar quando o usuário fornecer um valor negativo. Não se esqueça que o usuário pode entrar
  como primeiro número um número negativo, portanto, cuidado com a divisão por zero no cálculo da
  média. 
*/

using System;

class ExercicioF
{
    static void Main(string[] args)
    {
        int total = 0;
        int valor;
        int quantidadeValores = 0;

        do
        {
            Console.WriteLine("Insira um valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            if (valor >= 0)
            {
                total += valor;
                quantidadeValores++;
            }
        } while (valor >= 0);

        if (quantidadeValores > 0)
        {
            Console.WriteLine($"Somatório: {total}");
            Console.WriteLine($"Média: {total / quantidadeValores}");
            Console.WriteLine($"Total de valores lidos: {quantidadeValores}");
        }
        else
        {
            Console.WriteLine("Nenhum valor foi Lido!");
        }
    }
}