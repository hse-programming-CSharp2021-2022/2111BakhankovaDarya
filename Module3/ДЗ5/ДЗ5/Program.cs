using System;

namespace ДЗ5
{
    public interface IFunction
    {
        public double Function(double x)
        {
            throw new NotImplementedException();
        }
    }
    class F : IFunction
    {
        public delegate double Calculate(double x);
        public Calculate calculte;
    }
    class G
    {
        public F fx;
        public F gf;
        public G(F fx, F gf)
        {
            this.fx = fx;
            this.gf = gf;
        }
        public double GF(double x) => gf.calculte(fx.calculte(x));
    }
    class Program
    {
        static void Main(string[] args)
        {
            F f1 = new F();
            f1.calculte += (double x) =>
            {
                return x * x - 4;
            };
            F f2 = new F();
            f2.calculte += (double x) =>
            {
                return Math.Sin(x);
            };
            G g = new G(f2, f1);
            Console.WriteLine(g.GF(0));
            Console.WriteLine(g.GF(Math.PI / 2));
        }
    }
}
