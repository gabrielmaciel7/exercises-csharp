using System;
using System.Collections.Generic;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            var number1 = float.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            var number2 = float.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            var number3 = float.Parse(Console.ReadLine());

            var numbers = new List<float> { number1, number2, number3 };

            Console.WriteLine($"Maior: {numbers.Max()}");
        }
    }
}
