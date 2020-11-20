using System;
using System.Collections.Generic;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            var a = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("A equação não é do segundo grau.");
                return;
            }

            Console.Write("Digite o valor de b: ");
            var b = float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            var c = float.Parse(Console.ReadLine());

            var delta = Delta(a, b, c);

            if (delta < 0)
            {
                Console.WriteLine("A equação não possui raizes reais.");
                return;
            }

            var roots = Roots(a, b, delta);

            if (delta == 0)
            {
                Console.WriteLine("A equação possui apenas uma raiz real.");
                Console.WriteLine($"Raíz: {roots[0]}");
                return;
            }

            Console.WriteLine($"Raíz 1: {roots[0]}");
            Console.WriteLine($"Raíz 2: {roots[1]}");

        }

        static float Delta(float a, float b, float c)
        {
            return (b * b) - (4 * a * c);
        }

        static List<float> Roots(float a, float b, float delta)
        {
            var root1 = ((-b) + (float)Math.Sqrt(delta)) / (2 * a);
            var root2 = ((-b) - (float)Math.Sqrt(delta)) / (2 * a);

            return new List<float> { root1, root2 };
        }
    }
}
