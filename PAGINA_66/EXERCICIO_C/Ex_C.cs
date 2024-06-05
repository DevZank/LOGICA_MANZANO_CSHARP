/* 
    Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4+...+98+99+100)
*/

using System;

class ExercicioC
{
    static void Main(string[] args)
    {
        int soma = 0;

        for (int contadora = 1; contadora <= 100; contadora++)
        {
            soma += contadora;
        }

        Console.WriteLine($"A  soma dos 100 primeiros números inteiros é; {soma}");
    }
}