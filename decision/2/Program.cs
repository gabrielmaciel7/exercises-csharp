using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            var number = float.Parse(Console.ReadLine());

            var isPositive = number >= 0;

            Console.WriteLine(isPositive ? "Positivo" : "Negativo");
        }
    }
}
