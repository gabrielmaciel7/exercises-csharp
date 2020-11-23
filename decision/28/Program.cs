using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tipo de carne (F - Filé Duplo, A - Alcatra, P - Picanha): ");
            var beefType = Console.ReadLine().ToUpper();

            if (beefType != "F" && beefType != "A" && beefType != "P")
            {
                return;
            }

            Console.Write("Quantidade de carne (kg): ");
            var beefKg = int.Parse(Console.ReadLine());

            Console.Write("Forma de pagamento (C - Cartão Tabajara, D - Dinheiro): ");
            var payment = Console.ReadLine().ToUpper();

            IBeef beef = beefType switch
            {
                "F" => new DoubleFillet(beefKg),
                "A" => new Rump(beefKg),
                _ => new FiletSteak(beefKg)
            };

            var beefTypeString = beefType switch
            {
                "F" => "Filé Duplo",
                "A" => "Alcatra",
                _ => "Picanha"
            };

            var totalPrice = beef.TotalPrice();
            var discount = payment == "C" ? 0.05F * totalPrice : 0F;

            Console.WriteLine();
            Console.WriteLine($"Tipo de carne: {beefTypeString}");
            Console.WriteLine($"Quantidade de carne: {beefKg} kg");
            Console.WriteLine($"Preço total: {totalPrice:c2}");
            Console.WriteLine($"Desconto: {discount:c2}");
            Console.WriteLine($"Valor a pagar: {(totalPrice - discount):c2}");
        }
    }
}
