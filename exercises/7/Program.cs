using _7.Entities;
using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o lado do quadrado: ");
            var side = float.Parse(Console.ReadLine());

            var square = new Square(side);
            var squareArea = square.Area();

            Console.WriteLine($"Dobro da área: {squareArea * 2}");
        }
    }
}
