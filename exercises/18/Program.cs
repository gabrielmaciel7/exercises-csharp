using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho de um arquivo para download (em MB): ");
            var fileSize = float.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade de um link de Internet (em Mbps): ");
            var speed = float.Parse(Console.ReadLine());

            var downloadTime = DownloadTime(fileSize, speed);
            var downloadTimeMinutes = SecondsToMinutes(downloadTime);

            Console.WriteLine($"Tempo aproximado de download do arquivo usando este link: {Math.Round(downloadTimeMinutes):F0} min");
        }

        static float DownloadTime(float fileSize, float speed)
        {
            return fileSize / speed;
        }

        static float SecondsToMinutes(float seconds)
        {
            return seconds / 60;
        }
    }
}
