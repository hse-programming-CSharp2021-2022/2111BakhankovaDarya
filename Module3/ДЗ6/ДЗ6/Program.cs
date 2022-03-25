using System;
using System.Collections.Generic;

namespace ДЗ6
{
    struct Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point(double x, double y) => (X, Y) = (x, y);
        public double Distance(double x1, double y1) =>
            Math.Sqrt((X - x1) * (X - x1) + (Y - y1) * (Y - y1));
    }
    struct Circle : IComparable
    {
        public Point center { get; private set; }
        private double rad;
        public double Rad
        {
            get
            { return rad; }
            private set { rad = value; }
        }
        public Circle(double x, double y, double rad)
        {
            this.rad = rad;
            center = new Point(x, y);
        }
        public override string ToString()
        {
            return $"center = ({center.X},{center.Y}), rad = {rad} ";
        }

        public int CompareTo(object obj)
        {
            if (obj is Circle circle)
            {
                double param_left = this.Rad * this.center.Distance(0, 0);
                double param_rigth = circle.Rad * circle.center.Distance(0, 0);
                if (param_left > param_rigth)
                    return 1;
                else if (param_left == param_rigth)
                    return 0;
                else return -1;
            }
            else
                throw new Exception("объект должен быть типа Circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // в тз просили помещать данные в лист, а потом листы в массив, я этим не пользовалась,
            // так как много кода, проще сразу создавать объекты Circle. 
            // Предполагаем, что все данные корректны
            /*List<double> circ1 = new List<double>() { 1, 2, 3 };
            List<double> circ2 = new List<double>() { 1, 2, 3 };
            List<double> circ3 = new List<double>() { 1, 2, 3 };
            List<double>[] data = new List<double>[] { circ1, circ2, circ3 };*/
            //
            Circle[] circles = new Circle[] { new Circle(5, 5, 3), new Circle(1, 1, 3), new Circle(2, 2, 3) };
            Array.Sort(circles, (left, right) =>
            {
                double param_left = left.Rad * left.center.Distance(0, 0);
                double param_rigth = right.Rad * right.center.Distance(0, 0);
                if (param_left > param_rigth)
                    return 1;
                else if (param_left == param_rigth)
                    return 0;
                else return -1;
            });
            foreach (var circle in circles)
                Console.WriteLine(circle);

            Array.Sort(circles);
            foreach (var circle in circles)
                Console.WriteLine(circle);
        }
    }
}
