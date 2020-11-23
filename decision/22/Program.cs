using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            var number = int.Parse(Console.ReadLine());

            var isEven = number % 2 == 0;

            Console.WriteLine(isEven ? "Par" : "Ímpar");
        }
    }
}
