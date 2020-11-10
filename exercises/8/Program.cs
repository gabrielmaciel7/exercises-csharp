using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da hora trabalhada: ");
            var hrValue = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas trabalhadas no mês: ");
            var hrsWorked = int.Parse(Console.ReadLine());

            var salary = Salary(hrValue, hrsWorked);

            Console.WriteLine($"Salário no mês: {salary}");
        }

        static float Salary(float hrValue, int hrsWorked)
        {
            return hrValue * hrsWorked;
        }
    }
}
