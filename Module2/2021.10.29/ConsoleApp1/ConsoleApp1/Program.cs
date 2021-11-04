using System;
//2021.10.29
namespace ConsoleApp1
{
    class MyComplex
    {
        double re, im;
        public MyComplex(double xre, double xim)
        { re = xre; im = xim; }
        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }
        public double Mod() { return Math.Abs(re * re + im * im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re + b.re, a.im + b.im);
        }
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re * b.im - a.im * b.re, a.im * b.re + a.re * b.im);
        }
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re - b.re, a.im - b.im);
        }
        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new MyComplex((a.re * b.re + a.im * b.im) / (b.im * b.im + b.re * b.re), (a.im * b.re - a.re * b.im) / (b.re * b.re + b.im * b.im));
        }
        public override string ToString()
        {
            return re + "+(" + im + ")i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyComplex a = new MyComplex(1, 2);
            MyComplex b = new MyComplex(3, 4);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }
}
