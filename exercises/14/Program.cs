using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso de peixes (kg): ");
            var weight = float.Parse(Console.ReadLine());

            var excess = CalculateExcess(weight);
            var fine = CalculateFine(excess);

            Console.WriteLine($"Excesso: {excess}");
            Console.WriteLine($"Multa: {fine}");
        }

        static float CalculateExcess(float weight)
        {
            var limit = 50;

            if (weight < limit)
            {
                return 0;
            }

            return weight - limit;
        }

        static float CalculateFine(float excess)
        {
            var finePerKg = 4F;

            return excess * finePerKg;
        }
    }
}
