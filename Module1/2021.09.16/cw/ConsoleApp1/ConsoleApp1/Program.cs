//первая задача на семинаре 2021.09.16
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int a = int.Parse(s1);
            int amin = a % 10, amax = a % 10, k;
            while (a > 0)
            {
                k = a % 10;
                if (k < amin)
                    amin = k;
                if (k > amax)
                    amax = k;
                a /= 10;
            }
            Console.WriteLine(amin);
            Console.WriteLine(amax);
        }
    }
}
//вторая задача на семинаре.

/*using System;
namespace ConsoleApp1
{
    class Program
    {
        public static void MyMethod(ref int number)
        {
            int k, number1 = 0;
            while (number > 0)
            {
                k = number % 10;
                number1 *= 10;
                number1 += k;
                number /= 10;
            }
            number = number1;
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int a = int.Parse(s1);

            MyMethod(ref a);
        }
    }
}*/