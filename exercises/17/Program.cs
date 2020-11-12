using _17.Entities;
using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho em metros quadrados da área a ser pintada: ");
            var area = float.Parse(Console.ReadLine());
            Console.WriteLine();

            var paintCan = new PaintCan(area);
            var paintGallon = new PaintGallon(area);
            var paintCanAndGallon = new PaintCanAndGallon(area);

            Console.WriteLine("Comprar apenas latas de 18 litros");
            Console.WriteLine($"Quantidade: {paintCan.CalculateAmount()}");
            Console.WriteLine($"Preço: R${paintCan.CalculatePrice():F2}");
            Console.WriteLine();

            Console.WriteLine("Comprar apenas galões de 3,6 litros");
            Console.WriteLine($"Quantidade: {paintGallon.CalculateAmount()}");
            Console.WriteLine($"Preço: R${paintGallon.CalculatePrice():F2}");
            Console.WriteLine();

            Console.WriteLine("Misturar latas e galões, de forma que o desperdício de tinta seja menor");
            Console.WriteLine($"Quantidade de latas: {paintCanAndGallon.CalculateAmount().paintCans}");
            Console.WriteLine($"Preço das latas: R${paintCanAndGallon.CalculatePrice().paintCansPrice:F2}");
            Console.WriteLine($"Quantidade de galões: {paintCanAndGallon.CalculateAmount().paintGallons}");
            Console.WriteLine($"Preço dos galões: R${paintCanAndGallon.CalculatePrice().paintGallonsPrice:F2}");
            Console.WriteLine();
        }
    }
}
