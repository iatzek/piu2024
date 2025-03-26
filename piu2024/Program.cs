using System;

namespace piu2024
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("brak rozwiazan");
            } else
            {
                Console.WriteLine($"rozwiazania to {(-b - Math.Sqrt(delta)) / 2 * a}");
                Console.WriteLine($"rozwiazania to {(-b + Math.Sqrt(delta)) / 2 * a}");
            }


        }
    }
}
