/*
    Elaborar um programa de computador que efetue a leitura de quatro valores inteiros (variáveis A, B, C e
    D). Ao final o programa deve apresentar o resultado do produto (variável P) do primeiro com o terceiro
    valor, e o resultado do produto (variável P) do primeiro com o terceiro valor, e o resultado da soma
    (variável S) do segundo com o quarto valor.
*/

using System;

class ExercicioA
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor da Variavel A: ");
        int valorA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor da Variavel B:");
        int valorB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor da Variavel C: ");
        int valorC = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor da Variavel D:");
        int valorD = Convert.ToInt32(Console.ReadLine());

        int Produto = valorA * valorC;

        Console.WriteLine("");
        Console.WriteLine("===========================");
        Console.WriteLine($"O Produto de {valorA} x {valorC} = {Produto}");

        int Soma = valorB + valorD;

        Console.WriteLine($"A soma de {valorB} + {valorD} = {Soma}");
        Console.WriteLine("===========================");
    }
}