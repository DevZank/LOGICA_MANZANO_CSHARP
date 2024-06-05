/* 
  Efetuar a leitura de cinco números inteiros e identificar o maior e o menor valores.
*/

using System;

class ExercioH
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro numero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro numero: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o quarto numero: ");
        double numero4 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o quinto numero: ");
        double numero5 = Convert.ToDouble(Console.ReadLine());

        double menor = numero1;
        double maior = numero1;

        if (numero2 < menor)
        {
            menor = numero2;
        }
        else if (numero2 > maior)
        {
            maior = numero2;
        }

        if (numero3 < menor)
        {
            menor = numero3;
        }
        else if (numero3 > maior)
        {
            maior = numero3;
        }

        if (numero4 < menor)
        {
            menor = numero4;
        }
        else if (numero4 > maior)
        {
            maior = numero4;
        }

        if (numero5 < menor)
        {
            menor = numero5;
        }
        else if (numero5 > maior)
        {
            maior = numero5;
        }

        Console.WriteLine($"O Maior valor foi: {maior}");
        Console.WriteLine($"O Menor valor foi: {menor}");
    }
}