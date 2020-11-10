using System;
using System.Diagnostics.CodeAnalysis;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do primeiro bimestre: ");
            var score1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do segundo bimestre: ");
            var score2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do terceiro bimestre: ");
            var score3 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do quarto bimestre: ");
            var score4 = float.Parse(Console.ReadLine());

            var average = Average(score1, score2, score3, score4);

            Console.WriteLine($"Média: {average}");
        }

        static float Average(float score1, float score2, float score3, float score4)
        {
            var sum = score1 + score2 + score3 + score4;

            return sum / 4;
        }
    }
}
