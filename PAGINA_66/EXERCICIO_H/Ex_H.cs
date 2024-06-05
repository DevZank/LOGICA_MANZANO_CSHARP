/* 
    Elaborar um programa que apresente como resultado o valor de uma potência de uma base
    qualquer elevada a um expoente qualquer, ou seja, de BE, em que B é o valor da base e E o valor
    do expoente. Observe que neste exercício não pode ser utilizado o operador de exponenciação do
    portuguol (^). 
*/

using System;

class ExercicioH
{
    static void Main(string[] args)
    {
        int valor;
        int expoente;
        int resultado = 1;

        Console.WriteLine("Digite um valor: ");
        valor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor do expoente: ");
        expoente = Convert.ToInt32(Console.ReadLine());

        for (int contadora = 1; contadora <= expoente; contadora++)
        {
            resultado *= valor;
        }

        Console.WriteLine($"{valor} ^ {expoente} = {resultado}");
    }
}