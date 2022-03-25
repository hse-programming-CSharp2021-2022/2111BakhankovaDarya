

using System;

namespace _01_a_1
{
    delegate int Cast(double a);
    class Program
    {

        static void Main(string[] args)
        {
            // округление числа до ближайшего четного
            Cast Cast1 = delegate (double a)
            {
                var aRounded = (int)Math.Round(a);
                if (aRounded % 2 == 0)
                    return aRounded;
                else
                {
                    aRounded = aRounded > a ? (aRounded - 1) : (aRounded + 1);
                    return aRounded;
                }
            };

            
            // вычисление порядка положительного числа
            Cast Cast2 = delegate (double a)
            {
                if (a <= 0)
                    throw new ArgumentException("number has to be > 0");
                else
                {
                    int n = 0;
                    if (a <= 1)
                    {
                        while (a < 1)
                        {
                            n++;
                            a *= 10;
                        }
                        return -n;
                    }
                    else
                    {
                        while (a >= 10)
                        {
                            n++;
                            a /= 10;
                        }
                        return n;
                    }

                }
            };
           // Cast1 += Cast2;
            double[] arr1 = { -2, -2.01, -3.01, 0, 1, 2, 1.2, 1.8, 2.2, 2.8 };
            foreach (double a in arr1)
                try
                {
                    Console.WriteLine("bliz chetnoe k " + a + " = " + Cast1?.Invoke(a));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

            Console.WriteLine();

            double[] arr2 = { -1, 0, 1, 2, 0.01, 0.015, 12, 12.5 };
            foreach (double a in arr2)
            {
                try
                {
                    Console.WriteLine("poryadok chisla " + a + " = " + Cast2?.Invoke(a));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            // дополнительные пункты в задаче (на следующем слайде) 
            Cast Cast3 = Cast1 + Cast2;
            Console.WriteLine();
            Console.WriteLine(Cast3?.Invoke(11.05));
            // Cast1, но через лямбду
            Cast Cast1_1 = a =>
            {
                var aRounded = (int)Math.Round(a);
                if (aRounded % 2 == 0)
                    return aRounded;
                else
                {
                    aRounded = aRounded > a ? (aRounded - 1) : (aRounded + 1);
                    return aRounded;
                }
            };

            Cast3 += Cast1_1;
            Cast3 -= Cast1_1;
            
        }
    }
}
