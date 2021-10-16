//за 2021.09.23
using System;
namespace seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите n:");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += (i + 0.3) / (3 * i * i + 5);
                Console.WriteLine("k=" + i + " s=" + s);
            }
        }
    }
}