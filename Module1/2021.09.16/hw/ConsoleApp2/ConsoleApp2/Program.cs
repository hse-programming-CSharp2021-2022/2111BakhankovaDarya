using System;
//2021.09.16 дз
class Program
{
    static void Main()
    {
        int x = Math.Abs(int.Parse(Console.ReadLine()));
        if (x == 0)
        {
            Console.WriteLine("min= 0");
            Console.WriteLine("max= 0");
            return;
        }
        int min = 10;
        int max = 0;

        while (x > 0)
        {
            int k = x % 10;
            if (k > max)
                max = k;
            if (k < min)
                min = k;
            x /= 10;
        }
        Console.WriteLine("min= " + min);
        Console.WriteLine("max=" + max);
    }
}