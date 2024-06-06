using System;

class ExercicioC
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de votos váilidos para o canditado A: ");
        int votosA = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de votos váilidos para o canditado B: ");
        int votosB = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de votos váilidos para o canditado C: ");
        int votosC = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de votos nulos: ");
        int votosNulos = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de votos em branco: ");
        int votosBrancos = int.Parse(Console.ReadLine());

        int totalEleitores = votosA + votosB + votosC + votosNulos + votosBrancos;

        double porcentagemValidos = (double)(votosA + votosB + votosC) / totalEleitores * 100;
        double porcentagemA = (double)votosA / totalEleitores * 100;
        double porcentagemB = (double)votosB / totalEleitores * 100;
        double porcentagemC = (double)votosC / totalEleitores * 100;
        double porcentagemNulos = (double)votosNulos / totalEleitores * 100;
        double porcentagemBrancos = (double)votosBrancos / totalEleitores * 100;

        Console.WriteLine("\nResultados da Eleição: ");
        Console.WriteLine($"Número total de eleitores: {totalEleitores}");
        Console.WriteLine($"Percentual de votos válidos: {Math.Round(porcentagemValidos, 2)}%");
        Console.WriteLine($"Percentual de votos válidos do Candidato A: {Math.Round(porcentagemA, 2)}%");
        Console.WriteLine($"Percentual de votos válidos do Candidato B: {Math.Round(porcentagemB, 2)}%");
        Console.WriteLine($"Percentual de votos válidos do Candidato C: {Math.Round(porcentagemC, 2)}%");
        Console.WriteLine($"Percentual de votos nulos: {Math.Round(porcentagemNulos, 2)}%");
        Console.WriteLine($"Percentual de votos em branco: {Math.Round(porcentagemBrancos, 2)}%");
    }
}