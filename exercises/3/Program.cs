using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            var number1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            var number2 = float.Parse(Console.ReadLine());

            var sum = Sum(number1, number2);

            Console.WriteLine($"Soma: {sum}");
        }

        static float Sum(float number1, float number2)
        {
            return number1 + number2;
        }
    }
}
