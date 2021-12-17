using System;

namespace HW1_presentation2_01a_task2
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Point(double x, double y) { X = x; Y = y; }
            public Point() : this(0, 0) { } // конструктор умолчания
            public double Ro
            {
                get
                {
                    return Math.Sqrt(X * X + Y * Y);
                }
            }
            public double Fi
            {
                get
                {
                    if (X > 0 && Y >= 0)
                        return Math.Atan(Y / X);
                    if (X > 0 && Y < 0)
                        return Math.Atan(Y / X) + 2 * Math.PI;
                    if (X < 0)
                        return Math.Atan(Y / X) + Math.PI;
                    else
                    {
                        if (Y > 0)
                            return Math.PI / 2;
                        if (Y < 0)
                            return 3 * Math.PI / 2;
                        else
                            return 0;
                    }
                }
            }
            public string PointData
            {   // СВОЙСТВО 
                get
                {
                    string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                    return string.Format(maket, X, Y, Ro, Fi);
                }
            }

        }

        static void Main()
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                Point[] abc = { a, b, c };

                Array.Sort(abc, (x1, y1) => x1.Ro.CompareTo(y1.Ro));
                for (int i = 0; i < abc.Length - 1; i++)
                {
                    if (abc[i].Ro > abc[i + 1].Ro)
                    {
                        var newPoint = abc[i];
                        abc[i] = abc[i + 1];
                        abc[i + 1] = newPoint;

                    }
                }
                for (int i = 0; i < abc.Length; i++)
                    Console.WriteLine(abc[i].PointData);
            } while (x != 0 | y != 0);


        }

    }
}

