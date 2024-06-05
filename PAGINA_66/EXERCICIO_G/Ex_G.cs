using System;

class ExercicioG
{
    static void Main(string[] args)
    {
        int valor = 3;
        int resultado = 1;

        Console.WriteLine($"{valor} ^ 0 = {resultado}");

        for (int contadora = 1; contadora <= 15; contadora++)
        {
            resultado *= valor;
            Console.WriteLine($"{valor} ^ {contadora} = {resultado}");
        }
    }
}