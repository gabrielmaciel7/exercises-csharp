using System;
using System.Collections.Generic;
using System.Linq;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite valor de saque: ");
            var value = int.Parse(Console.ReadLine());

            if (value > 600 || value < 10)
            {
                Console.WriteLine("O valor mínimo é de 10 reais e o máximo de 600 reais.");
                return;
            }

            foreach (var banknote in Calculate(value))
            {
                Console.WriteLine(banknote);
            }
        }

        static List<string> Calculate(int value)
        {
            var banknotesList = new List<string>();
            var banknotesAvailable = new List<int> { 1, 5, 10, 50, 100 };

            foreach (var banknote in banknotesAvailable.OrderByDescending(bn => bn))
            {
                if (value > 0)
                {
                    var qte = value / banknote;
                    value %= banknote;

                    var text = qte switch
                    {
                        0 => null,
                        1 => $"uma nota de {banknote}",
                        _ => $"{qte} notas de {banknote}"
                    };

                    if (text != null)
                    {
                        banknotesList.Add(text);
                    }
                }
            }

            return banknotesList;
        }
    }
}
