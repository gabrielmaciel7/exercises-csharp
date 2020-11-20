using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro menor do que 1000: ");
            var number = int.Parse(Console.ReadLine());

            if (number >= 1000)
            {
                Console.WriteLine("Número maior do que 999.");
                return;
            }

            Console.WriteLine(Calculate(number));
        }

        static string Calculate(int number)
        {
            var hundred = number / 100;
            var hundredRest = number % 100;

            var ten = hundredRest / 10;

            var unit = hundredRest % 10;

            var hundredText = hundred switch
            {
                0 => $"",
                1 => $"1 centena",
                _ => $"{hundred} centenas"
            };

            var tenText = ten switch
            {
                0 => $"",
                1 => $"1 dezena",
                _ => $"{ten} dezenas"
            };

            var unitText = unit switch
            {
                0 => $"",
                1 => $"1 unidade",
                _ => $"{unit} unidades"
            };

            if (hundredText != "" && tenText != "" && unitText != "")
            {
                hundredText += ", ";
                tenText += " e ";
            }
            else if (hundredText != "" && (tenText != "" || unitText != ""))
            {
                hundredText += " e ";
            }
            else if (tenText != "" && unitText != "")
            {
                tenText += " e ";
            }

            return $"{hundredText}{tenText}{unitText}";
        }
    }
}
