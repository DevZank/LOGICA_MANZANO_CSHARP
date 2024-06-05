/*
  Elaborar um programa que possibilite calcular a área total de uma residência (sala, cozinha,
  banheiro, quartos, área de serviço, quintal, garagem, etc.). O programa deve solicitar a entrada do
  nome, a largura e o comprimento de um determinado cômodo. Em seguida, deve apresentar a área
  do cômodo lido e também uma mensagem solicitando do usuário a confirmação de continuar
  calculando novos cômodos. Caso o usuário responda “NAO”, o programa deve apresentar o valor
  total acumulado da área residencial.
*/

using System;

class ExercioK
{
    static void Main(string[] args)
    {
        double largura_comodo = 0;
        double altura_comodo = 0;
        double area_comodo = 0;
        string verificacao = "S";
        string nome_comodo = "";

        while (verificacao == "S")
        {
            Console.WriteLine("Escreva o nome do comodo da casa: ");
            nome_comodo = Console.ReadLine();
            Console.WriteLine("Escreva a largura do comodo em metros: ");
            largura_comodo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva a altura do comodo em metros: ");
            altura_comodo = Convert.ToDouble(Console.ReadLine());

            area_comodo = altura_comodo * largura_comodo;

            Console.WriteLine($"A area do comodo {nome_comodo} é: {area_comodo}m²");
            Console.WriteLine("Continuar? S/N");
            verificacao = Console.ReadLine();
        }
    }
}