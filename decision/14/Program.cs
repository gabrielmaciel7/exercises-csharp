using System;
using System.Collections.Generic;
using System.Linq;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma nota: ");
            var grade1 = float.Parse(Console.ReadLine());

            Console.Write("Digite outra nota: ");
            var grade2 = float.Parse(Console.ReadLine());

            var grades = new List<float> { grade1, grade2 };

            var average = grades.Average();

            var classification = average switch
            {
                var avg when (avg >= 9) => new { Rate = "A", Evaluation = "APROVADO" },
                var avg when (avg >= 7.5) => new { Rate = "B", Evaluation = "APROVADO" },
                var avg when (avg >= 6) => new { Rate = "C", Evaluation = "APROVADO" },
                var avg when (avg >= 4) => new { Rate = "D", Evaluation = "REPROVADO" },
                _ => new { Rate = "E", Evaluation = "REPROVADO" }
            };

            Console.WriteLine($"Notas: {grade1:F2} e {grade2:F2}");
            Console.WriteLine($"Média: {average:F2}");
            Console.WriteLine($"Conceito: {classification.Rate}");
            Console.WriteLine($"{classification.Evaluation}");
        }
    }
}
