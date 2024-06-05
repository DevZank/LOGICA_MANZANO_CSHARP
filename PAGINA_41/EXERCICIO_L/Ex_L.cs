/* 
  Elaborar um programa que efetue a leitura do nome e do sexo de uma pessoa, apresentando com
  saída uma das seguintes mensagens: "Ilmo Sr.", se o sexo informado como masculino, ou a
  mensagem "Ilma Sra.", para o sexo informado como feminino. Apresente também junto da
  mensagem de saudação o nome previamente informado. 
*/

using System;

class ExercioL
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite seu nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite seu Sexo (M | F): ");
    string sexo = Console.ReadLine();

    if (sexo == "M")
    {
      Console.WriteLine($"Ilmo Sr. {nome}");
    }
    else if (sexo == "F")
    {
      Console.WriteLine($"Ilmo Sra. {nome}");
    }
    else
    {
      Console.WriteLine("SEXO INSERIDO INVALIDO!");
    }
  }
}