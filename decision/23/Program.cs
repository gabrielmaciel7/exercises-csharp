using System;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            var number = double.Parse(Console.ReadLine());

            var isDecimal = Math.Round(number) != number;

            Console.WriteLine(isDecimal ? "Decimal" : "Inteiro");
        }
    }
}
