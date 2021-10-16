//первая задача за семинар 2021.09.17
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            double k = 2;
            double p, s1;
            do
            {
                s1 = s;
                p = 1 / ((k - 1) * (k) * (k + 1));
                s += p;
                k++;
            } while (s1 - s != 0);
            Console.WriteLine("double: " + s);
            float sn = 0;
            float kn = 2;
            float pn, s1n;
            do
            {
                s1n = sn;
                pn = 1 / ((kn - 1) * (kn) * (kn + 1));
                sn += pn;
                kn++;
            } while (s1n - sn != 0);
            Console.WriteLine("float: " + sn);

        }
    }
}
//вторая задача

/*using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double kap = Double.Parse(Console.ReadLine());
            double let = Double.Parse(Console.ReadLine());
            double procent = Double.Parse(Console.ReadLine());
            double summ = kap;
            for (int i = 1; i <= let; i++)
            {
                summ *= (1 + procent / 100);
                Console.WriteLine(i + " year: " + summ);
            }
        }
    }
}*/