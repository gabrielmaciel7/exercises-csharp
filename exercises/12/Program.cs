using _12.Entities;
using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura (h) de uma pessoa: ");
            var height = float.Parse(Console.ReadLine());

            var person = new Person(height);
            var idealWeight = person.IdealWeight();

            Console.WriteLine($"Peso ideal: {idealWeight}");
        }
    }
}
