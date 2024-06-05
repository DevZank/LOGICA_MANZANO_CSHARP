/* 
  Elaborar um programa que efetue a leitura de um valor que esteja entre a faixa de 1 a 9. Após a
  leitura do valor fornecido pelo usuário, o programa deverá indicar uma de duas mensagens: "O
  valor está na faixa permitida", caso o usuário forneça o valor nesta faixa, ou a mensagem "O valor
  está fora da faixa permitida", caso o usuário forneça valores menores que 1 ou maiores que 9. 
*/

using System;

class ExercioJ
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero entre 1 e 9: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 1 && numero <= 9)
        {
            Console.WriteLine("O valor esta na faixa permitida!");
        }
        else
        {
            Console.WriteLine("O valor esta fora da faixa permitida!")
        }
    }
}