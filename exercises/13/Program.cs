using _13.Entities;
using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a altura (h) de uma pessoa: ");
            var height = float.Parse(Console.ReadLine());

            var person = new Person(height);
            var idealWeightForMen = person.IdealWeightForMen();
            var idealWeightForWomen = person.IdealWeightForWomen();

            Console.WriteLine($"Peso ideal para homens: {idealWeightForMen}");
            Console.WriteLine($"Peso ideal para mulheres: {idealWeightForWomen}");
        }
    }
}
