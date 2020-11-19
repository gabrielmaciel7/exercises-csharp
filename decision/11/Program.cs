using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário do colaborador: ");
            var salary = float.Parse(Console.ReadLine());

            var rateOfIncrease = salary switch
            {
                var s when (s <= 280) => 0.2F,
                var s when (s <= 700) => 0.15F,
                var s when (s <= 1500) => 0.1F,
                _ => 0.05F
            };

            var increase = salary * rateOfIncrease;

            Console.WriteLine($"Salário antes do reajuste: {salary:c2}");
            Console.WriteLine($"Percentual de aumento aplicado: {(rateOfIncrease * 100):F2}%");
            Console.WriteLine($"Valor do aumento: {increase:c2}");
            Console.WriteLine($"Novo salário, após o aumento: {(increase + salary):c2}");
        }
    }
}
