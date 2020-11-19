using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowels = new List<string> { "A", "E", "I", "O", "U" };

            Console.Write("Digite uma letra: ");
            var letter = Console.ReadLine();

            var isVowel = vowels.Contains(letter.ToUpper());

            Console.WriteLine(isVowel ? "Vogal" : "Consoante");
        }
    }
}
