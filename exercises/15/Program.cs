using _15.Entities;
using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quanto você ganha por hora: ");
            var gainPerHour = float.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas no mês: ");
            var workedHours = int.Parse(Console.ReadLine());

            var employee = new Employee(gainPerHour, workedHours);

            var grossWage = employee.GrossWage();
            var ir = employee.IR();
            var inss = employee.INSS();
            var union = employee.Union();
            var netSalary = employee.NetSalary();

            Console.WriteLine($"+ Salário Bruto : R${grossWage:F2}");
            Console.WriteLine($"- IR (11%) : R${ir:F2}");
            Console.WriteLine($"- INSS (8%) : R${inss:F2}");
            Console.WriteLine($"- Sindicato ( 5%) : R${union:F2}");
            Console.WriteLine($"= Salário Liquido : R${netSalary:F2}");
        }
    }
}
