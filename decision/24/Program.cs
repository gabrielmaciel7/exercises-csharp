using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            var number1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            var number2 = double.Parse(Console.ReadLine());

            Console.Write("Qual operação deseja realizar? (1 - par ou ímpar; 2 - positivo ou negativo; 3 - inteiro ou decimal)");
            var operation = int.Parse(Console.ReadLine());

            string result1 = "";
            string result2 = "";

            if (operation == 1)
            {
                result1 = number1 % 2 == 0 ? "Par" : "Ímpar";
                result2 = number2 % 2 == 0 ? "Par" : "Ímpar";
            } 
            else if (operation == 2)
            {
                result1 = number1 >= 0 ? "Positivo" : "Negativo";
                result2 = number2 >= 0 ? "Positivo" : "Negativo";
            }
            else if (operation == 3)
            {
                result1 = Math.Round(number1) != number1 ? "Decimal" : "Inteiro";
                result2 = Math.Round(number2) != number2 ? "Decimal" : "Inteiro";
            }

            Console.WriteLine($"Número 1: {result1}");
            Console.WriteLine($"Número 2: {result2}");
        }
    }
}
