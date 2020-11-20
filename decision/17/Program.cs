using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um ano: ");
            var year = int.Parse(Console.ReadLine());

            var isLeap = IsLeapYear(year);

            Console.WriteLine(isLeap ? "Ano bissexto." : "Não é bissexto.");
        }

        static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }

            if (year % 100 == 0)
            {
                if (year % 400 != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
