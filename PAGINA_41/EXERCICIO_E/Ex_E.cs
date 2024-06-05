/* 
  Efetuar a leitura de três valores (variáveis A, B e C) e efetuar o cálculo da equação completa de
  segundo grau, apresentando as duas raízes, se para os valores informados for possível efetuar o
  referido cálculo. Lembre-se de que a variável A deve ser diferente de zero. 
*/

using System;

class ExercioE
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor para ' A ':");
        double lerValorA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite um valor para ' B ':");
        double lerValorB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite um valor para ' C ':");
        double lerValorC = Convert.ToDouble(Console.ReadLine());

        double delta = 0;
        double resultadoA = 0;
        double resultadoB = 0;

        if (lerValorA == 0)
        {
            Console.WriteLine("Impossivel fazer a equação de segundo grau! O valor de A não pode ser Zero");
        }
        else
        {
            delta = Math.Pow(lerValorB, 2) - 4 * lerValorA * lerValorC;

            if (delta < 0)
            {
                Console.WriteLine("Não existe raizes Reais!");
            }
            else
            {
                resultadoA = (lerValorB + Math.Sqrt(delta)) / (2 * lerValorA);
                resultadoB = (lerValorB - Math.Sqrt(delta)) / (2 * lerValorA);

                Console.WriteLine($"A primeira raiz é {Math.Round(resultadoA, 4)} a segunda raiz é: {Math.Round(resultadoB, 4)}");
            }
        }
    }
}