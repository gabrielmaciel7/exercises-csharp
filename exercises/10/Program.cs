using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da temperatura em graus Celsius: ");
            var degreesC = float.Parse(Console.ReadLine());

            var degreesF = CelsiusToFahrenheit(degreesC);

            Console.WriteLine($"Temperatura em graus Fahrenheit: {degreesF}°F");
        }

        static float CelsiusToFahrenheit(float degreesC)
        {
            return (degreesC * 9 / 5) + 32;
        }
    }
}
