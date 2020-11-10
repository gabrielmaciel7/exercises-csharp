using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor em metros: ");
            var meters = float.Parse(Console.ReadLine());

            var centimeters = MetersToCentimeters(meters);

            Console.WriteLine($"Centimeters: {centimeters}");
        }

        static float MetersToCentimeters(float meters)
        {
            return meters * 100;
        }
    }
}
