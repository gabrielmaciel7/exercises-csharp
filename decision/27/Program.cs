using System;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de morangos (kg): ");
            var strawberry = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de maçãs (kg): ");
            var apple = int.Parse(Console.ReadLine());

            Console.WriteLine($"Total morangos: {new Strawberry(strawberry).TotalPrice():c2}");
            Console.WriteLine($"Total maçãs: {new Apple(apple).TotalPrice():c2}");
        }
    }
}
