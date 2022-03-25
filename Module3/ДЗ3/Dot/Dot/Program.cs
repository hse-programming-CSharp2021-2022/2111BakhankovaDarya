using System;

// module3_2a_page22

namespace Dot
{
    delegate void CoordChanged(Dot dot);
    class Dot
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static event CoordChanged OnCoordChanged;
        public void DotFlow()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                x = rnd.Next(-10, 10) + rnd.NextDouble();
                y = rnd.Next(-10, 10) + rnd.NextDouble();
                if (x < 0 && y < 0)
                    OnCoordChanged(new Dot(x, y));
            }
        }
    }
    class Program
    {
        static void PrintInfo(Dot A)
        {
            Console.WriteLine($"x: {A.x} y: {A.y}");
        }
        static void Main(string[] args)
        {
            // Dot dot = new Dot();
            double x;
            double y;
            try
            {
                Console.Write("X: ");
                x = Double.Parse(Console.ReadLine());
                Console.Write("Y: ");
                y = Double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Dot D = new Dot(x, y);
            Dot.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }
    }
}