using System;
using System.Collections.Generic;
using System.Linq;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço do produto 1: ");
            var price1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o preço do produto 2: ");
            var price2 = float.Parse(Console.ReadLine());

            Console.Write("Digite o preço do produto 3: ");
            var price3 = float.Parse(Console.ReadLine());

            var products = new List<Product>
            {
                new Product("Produto 1", price1),
                new Product("Produto 2", price2),
                new Product("Produto 3", price3)
            };

            var minProducts = products.Where(product => product.Price == products.Min(product => product.Price));

            foreach (var minProduct in minProducts)
            {
                Console.WriteLine($"Deve comprar: {minProduct.Name}");
            }
        }


    }
}
