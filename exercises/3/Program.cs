using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            var number1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            var number2 = int.Parse(Console.ReadLine());

            var soma = Soma(number1, number2);

            Console.WriteLine($"Soma: {soma}");
        }

        static int Soma(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
