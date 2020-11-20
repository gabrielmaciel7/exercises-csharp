using System;
using System.Collections.Generic;
using System.Linq;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um lado do triângulo: ");
            var side1 = float.Parse(Console.ReadLine());

            Console.Write("Digite outro lado do triângulo: ");
            var side2 = float.Parse(Console.ReadLine());

            Console.Write("Digite outro lado do triângulo: ");
            var side3 = float.Parse(Console.ReadLine());

            var sides = new List<float> { side1, side2, side3 };

            var isTriangle = IsTriangle(sides);

            Console.WriteLine(isTriangle ? "Pode ser um triângulo." : "Não pode ser um triângulo.");

            if (isTriangle)
            {
                var triangleType = TriangleType(sides);

                Console.WriteLine($"Tipo do triângulo: {triangleType}");
            }
        }

        static bool IsTriangle(List<float> sides)
        {
            var numberOfSides = 3;

            for (var side = 1; side <= numberOfSides; side++)
            {
                for (var sumSide = side + 1; sumSide <= numberOfSides; sumSide++)
                {
                    var comparedSide = sumSide + side;

                    if (side + sumSide > numberOfSides)
                    {
                        comparedSide = sumSide - side;
                    }

                    if (sides[side - 1] + sides[sumSide - 1] <= sides[comparedSide - 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static string TriangleType(List<float> sides)
        {
            var type = sides switch
            {
                var s when (s[0] == s[1] && s[0] == s[2]) => "Equilátero",
                var s when (s[0] == s[1] || s[0] == s[2] || s[1] == s[2]) => "Isósceles",
                var s when (s[0] != s[1] && s[0] != s[2] && s[1] != s[2]) => "Escaleno",
                _ => ""
            };

            return type;
        }
    }
}
