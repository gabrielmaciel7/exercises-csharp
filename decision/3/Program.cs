using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma letra: ");
            var letter = Console.ReadLine();

            var output = (letter.ToUpper()) switch
            {
                "F" => "F - Feminino",
                "M" => "M - Masculino",
                _ => "Sexo Inválido",
            };

            Console.WriteLine(output);
        }
    }
}
