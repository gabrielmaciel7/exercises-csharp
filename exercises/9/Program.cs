using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da temperatura em graus Fahrenheit: ");
            var degreesF = float.Parse(Console.ReadLine());

            var degreesC = FahrenheitToCelsius(degreesF);

            Console.WriteLine($"Temperatura em graus Celsius: {degreesC}°C");
        }

        static float FahrenheitToCelsius(float degreesF)
        {
            return 5 * ((degreesF - 32) / 9);
        }
    }
}
