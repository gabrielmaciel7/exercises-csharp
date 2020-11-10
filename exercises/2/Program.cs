using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            var number = float.Parse(Console.ReadLine());

            Console.WriteLine($"O número informado foi {number}");
        }
    }
}
