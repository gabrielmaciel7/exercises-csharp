using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma data (dd/mm/aaaa): ");

            try
            {
                var date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Data válida: {date:dd/MM/yyyy}");
            }
            catch
            {
                Console.WriteLine("Data inválida.");
            }
        }
    }
}
