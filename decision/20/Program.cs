using System;
using System.Collections.Generic;
using System.Linq;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma nota: ");
            var grade1 = float.Parse(Console.ReadLine());

            Console.Write("Digite outra nota: ");
            var grade2 = float.Parse(Console.ReadLine());

            Console.Write("Digite outra nota: ");
            var grade3 = float.Parse(Console.ReadLine());

            var grades = new List<float> { grade1, grade2, grade3 };

            var average = grades.Average();

            var output = (average) switch
            {
                10 => "Aprovado com Distinção",
                var avg when (avg >= 7) => $"Aprovado com média {average}",
                _ => $"Reprovado com média {average}",
            };

            Console.WriteLine(output);
        }
    }
}
