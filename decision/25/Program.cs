using System;
using System.Collections.Generic;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Responda as perguntas com 's' para SIM ou 'n' para NÃO:");

            Console.Write("Telefonou para a vítima? ");
            var response1 = Console.ReadLine();

            Console.Write("Esteve no local do crime? ");
            var response2 = Console.ReadLine();

            Console.Write("Mora perto da vítima? ");
            var response3 = Console.ReadLine();

            Console.Write("Devia para a vítima? ");
            var response4 = Console.ReadLine();

            Console.Write("Já trabalhou com a vítima? ");
            var response5 = Console.ReadLine();

            var responses = new List<string> { response1, response1, response3, response4, response5 };

            var result = 0;

            foreach (var response in responses)
            {
                if (response.ToUpper() == "S")
                {
                    result += 1;
                }
            }

            var classification = result switch
            {
                5 => "Assassino",
                var res when (res >= 3) => "Cúmplice",
                2 => "Suspeita",
                _ => "Inocente"
            };

            Console.WriteLine(classification);
        }
    }
}
