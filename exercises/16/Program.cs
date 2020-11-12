using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho em metros quadrados da área a ser pintada: ");
            var area = float.Parse(Console.ReadLine());

            var paintCans = CalculateAmountOfPaintCans(area);
            var price = CalculatePrice(paintCans);

            Console.WriteLine($"Quantidade de latas de tinta a serem compradas: {paintCans}");
            Console.WriteLine($"Preço total: R${price:F2}");
        }

        static int CalculateAmountOfPaintCans(float area)
        {
            var paintRate = (1F / 3);
            var canSize = 18;

            var litersRequired = paintRate * area;
            var cansRequired = (int)Math.Ceiling(litersRequired / canSize);

            return cansRequired;
        }

        static float CalculatePrice(int paintCans)
        {
            var unitPrice = 80F;

            return unitPrice * paintCans;
        }
    }
}
