/* 
  Ler quatro valores referentes a quatro notas escolares de um aluno e imprimir uma mensagem 
  dizendo que o aluno foi aprovado, se o valor da média escolar for maior ou igual a 7. Se o valor da 
  média for menor que 7, solicitar a nota de exame, somar com o valor da média e obter nova média. 
  Se a nova média for maior ou igual a 5, apresentar uma mensagem dizendo que o aluno foi 
  aprovado em exame. Se o aluno não foi aprovado, indicar uma mensagem informando esta 
  condição. Apresentar com as mensagens o valor da média do aluno, para qualquer condição. 
*/

using System;

class ExercioD
{
    static void Main(string[] args)
    {
        Console.Write("Digite a 1ª Nota: ");
        double primeiraNota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a 2ª Nota: ");
        double segundaNota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a 3ª Nota: ");
        double terceiraNota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a 4ª Nota: ");
        double quartaNota = Convert.ToDouble(Console.ReadLine());

        double mediaDoAluno = (primeiraNota + segundaNota + terceiraNota + quartaNota) / 4;

        if (mediaDoAluno >= 7)
        {
            Console.WriteLine($"O Aluno foi Aprovado com a média de: {Math.Round(mediaDoAluno, 2)}");
        }
        else
        {
            Console.WriteLine("Digite a Nota do Exame: ");
            double notaDoExame = Convert.ToDouble(Console.ReadLine());

            double novaMediaDoAluno = (mediaDoAluno + notaDoExame) / 2;

            if (novaMediaDoAluno >= 5)
            {
                Console.WriteLine($"O Aluno foi Aprovado por Exame. Nota da Media: {Math.Round(novaMediaDoAluno, 2)}");
            }
            else
            {
                Console.WriteLine($"O Aluno foi Reprovado. Nota da Media: {Math.Round(mediaDoAluno, 2)}");
            }
        }
    }
}