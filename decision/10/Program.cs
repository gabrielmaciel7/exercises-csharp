using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que turno você estuda? (M-matutino ou V-Vespertino ou N-Noturno) ");
            var shift = Console.ReadLine();

            var output = (shift.ToUpper()) switch
            {
                "M" => "Bom Dia!",
                "V" => "Boa Tarde!",
                "N" => "Boa Noite!",
                _ => "Valor Inválido!"
            };

            Console.WriteLine(output);
        }
    }
}
