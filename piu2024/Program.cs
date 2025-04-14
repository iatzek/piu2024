using System;
using System.Diagnostics;

namespace piu2024
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();

            double a,b,c;
            Console.WriteLine("Podaj a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = Double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Brak rozwiazan");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Jedno rozwiazanie: {-b / (2 * a)}");
            }
            else
            {
                Console.WriteLine($"Rozwiazania to {(-b - Math.Sqrt(delta)) / (2 * a)}");
                Console.WriteLine($"Rozwiazania to {(-b + Math.Sqrt(delta)) / (2 * a)}");
            }

            stopwatch.Stop();
            Console.WriteLine($"Czas wykonania: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
