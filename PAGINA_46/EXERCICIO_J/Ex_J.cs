using System;

class ExercioJ
{
    static void Main(string[] args)
    {
        double numero = 0;
        double media = 0;
        double soma = 0;
        double contador = 50;

        while (contador < 71)
        {
            if (contador % 2 == 0)
            {
                soma = contador + soma;
                Console.WriteLine(contador);
            }
            contador++;
        }

        media = soma / 11;

        Console.WriteLine($"O total da Soma foi: {soma}");
        Console.WriteLine($"O total da Média foi: {media}");
    }
}