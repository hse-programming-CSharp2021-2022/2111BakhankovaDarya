using System;

namespace _01_a_3
{
    delegate double DelegateConvertTemperature(double t);
    class TemperatureConverterImp
    {
        public double FToC(double f)
        {
            return 5.0 / 9.0 * (f - 32);
        }
        public double CToF(double c)
        {
            return 9.0 / 5.0 * c + 32;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverterImp temp = new TemperatureConverterImp();
            DelegateConvertTemperature CToF = new DelegateConvertTemperature(temp.CToF);
            DelegateConvertTemperature FToC = new DelegateConvertTemperature(temp.FToC);
            Console.WriteLine(FToC?.Invoke(100));
            Console.WriteLine(CToF?.Invoke(100));
        }
    }
}
