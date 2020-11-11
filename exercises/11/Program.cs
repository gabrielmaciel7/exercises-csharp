using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            var int1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número inteiro: ");
            var int2 = int.Parse(Console.ReadLine());

            Console.Write("Digite um número real: ");
            var real = float.Parse(Console.ReadLine());

            Console.WriteLine($"Produto do dobro do primeiro com metade do segundo: {(int1 * 2) * ((float)int2 / 2)}");
            Console.WriteLine($"Soma do triplo do primeiro com o terceiro: {(int1 * 3) + real}");
            Console.WriteLine($"Terceiro elevado ao cubo: {Math.Pow(real, 3)}");
        }
    }
}
