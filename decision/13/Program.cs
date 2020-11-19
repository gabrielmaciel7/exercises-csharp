using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            var number = int.Parse(Console.ReadLine());

            var weekDay = number switch
            {
                1 => "1 - Domingo",
                2 => "2 - Segunda",
                3 => "3 - Terça",
                4 => "4 - Quarta",
                5 => "5 - Quinta",
                6 => "6 - Sexta",
                7 => "7 - Sábado",
                _ => "Valor inválido"
            };

            Console.WriteLine($"Dia da semana: {weekDay}");
        }
    }
}
