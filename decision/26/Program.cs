using System;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de litros: ");
            var liters = int.Parse(Console.ReadLine());

            Console.Write("Combustível (G - gasolina ou A - álcool): ");
            var fuelType = Console.ReadLine().ToUpper();

            var fuelPrice = fuelType switch
            {
                "G" => new Gasoline(liters).Price(),
                "A" => new Alcohol(liters).Price(),
                _ => 0F
            };

            Console.WriteLine($"Total: {fuelPrice}");
        }
    }
}
