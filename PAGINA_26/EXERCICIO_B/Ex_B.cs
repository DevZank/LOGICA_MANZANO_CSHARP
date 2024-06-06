using System;

class ExercicioB
{
    static void Main(string[] args)
    {
        double salarioMensal;
        double reajuste;
        double novoSalario;

        Console.WriteLine("Salario Mensal: ");
        salarioMensal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Percentual de Reajuste: ");
        reajuste = Convert.ToDouble(Console.ReadLine());

        novoSalario = salarioMensal * reajuste / 100 + salarioMensal;

        Console.WriteLine($"O salario depois de ser Reajustado foi: R${novoSalario}");
    }
}