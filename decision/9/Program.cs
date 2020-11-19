using System;
using System.Collections.Generic;
using System.Linq;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número 1: ");
            var number1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número 2: ");
            var number2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o número 3: ");
            var number3 = int.Parse(Console.ReadLine());

            var numbers = new List<int> { number1, number2, number3 };

            Console.WriteLine("Decrescente:");

            foreach (var number in numbers.OrderByDescending(number => number))
            {
                Console.WriteLine(number);
            }
        }
    }
}
