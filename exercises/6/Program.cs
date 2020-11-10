using _6.Entities;
using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio do círculo: ");
            var radius = float.Parse(Console.ReadLine());

            var circle = new Circle(radius);
            var circleArea = circle.Area();

            Console.WriteLine($"Área: {circleArea}");
        }
    }
}
