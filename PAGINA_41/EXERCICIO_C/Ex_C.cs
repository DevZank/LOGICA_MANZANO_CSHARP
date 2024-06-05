/* 
  Ler quatro valores referentes a quatro notas escolares de um aluno e imprimir uma mensagem 
  dizendo que o aluno foi aprovado, se o valor da média escolar for maior ou igual a 5. Se o aluno não 
  foi aprovado, indicar uma mensagem informando esta condição. Apresentar junto das mensagens o 
  valor da média do aluno para qualquer condição.
*/

using System;

class ExercioC
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a 1ª Nota: ");
        int lerNota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a 2ª Nota: ");
        int lerNota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a 3ª Nota: ");
        int lerNota3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a 4ª Nota: ");
        int lerNota4 = Convert.ToInt32(Console.ReadLine());

        int notasMedia = (lerNota1 + lerNota2 + lerNota3 + lerNota4) / 4;

        if (notasMedia >= 5)
        {
            Console.WriteLine($"O aluno foi Aprovado com a média de: {notasMedia}");
        }
        else
        {
            Console.WriteLine($"O aluno foi Reprovado com a média de: {notasMedia}");
        }
    }
}