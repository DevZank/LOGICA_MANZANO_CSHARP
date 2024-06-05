/*
  Elaborar um programa que possibilite calcular a área total de uma residência (sala, cozinha,
  banheiro, quartos, área de serviço, quintal, garagem, etc.). O programa deve solicitar a entrada do
  nome, a largura e o comprimento de um determinado cômodo. Em seguida, deve apresentar a área
  do cômodo lido e também uma mensagem solicitando do usuário a confirmação de continuar
  calculando novos cômodos. Caso o usuário responda “NAO”, o programa deve apresentar o valor
  total acumulado da área residencial.
*/

using System;

class ExercicioH
{
  static void Main(string[] args)
  {
    string nome_comodo;
    string opcao;

    double largura;
    double comprimento;
    double total;
    double soma = 0;

    do
    {
      Console.WriteLine("Digite o nome do Comodo: ");
      nome_comodo = Console.ReadLine();

      Console.WriteLine("Digite o valor da largura: ");
      largura = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Digite o valor do comprimento: ");
      comprimento = Convert.ToInt32(Console.ReadLine());

      total = largura * comprimento;
      soma += total;

      Console.WriteLine("Deseja continuar? \nS - Sim \nN - Não ");
      opcao = Console.ReadLine();
    } while (opcao == "S");

    Console.WriteLine($"A area da residencia é de Aproximadamente {soma}m²");
  }
}