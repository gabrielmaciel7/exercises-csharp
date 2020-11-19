using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da sua hora: ");
            var hourValue = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas trabalhadas no mês: ");
            var hours = int.Parse(Console.ReadLine());

            var grossSalary = hourValue * hours;
            var inss = 0.1 * grossSalary;
            var fgts = 0.11 * grossSalary;

            var irRate = grossSalary switch
            {
                var s when (s <= 900) => 0F,
                var s when (s <= 1500) => 0.05F,
                var s when (s <= 2500) => 0.1F,
                _ => 0.2F
            };

            var ir = irRate * grossSalary;
            var discounts = ir + inss;
            var netSalary = grossSalary - discounts;

            Console.WriteLine($"Salário Bruto: ({hourValue} * {hours}): {grossSalary:c2}");
            Console.WriteLine($"(-) IR ({(irRate * 100):F0}%): {ir:c2}");
            Console.WriteLine($"(-) INSS (10%): {inss:c2}");
            Console.WriteLine($"FGTS (11%): {fgts:c2}");
            Console.WriteLine($"Total de descontos: {discounts:c2}");
            Console.WriteLine($"Salário Liquido: {netSalary:c2}");
        }
    }
}
