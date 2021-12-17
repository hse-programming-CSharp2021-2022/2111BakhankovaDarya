using System.IO;
using System;

namespace _10exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            try
            {
                int b = 0;
                var a = 5 / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            // 2.
            try
            {
                int[] array = { 0, 1, 2 };
                var a = array[5];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("(the 3rd one)");
            // 3.
            // в debug режиме это исключение почему-то не отлавливается. Точнее отлавливается, но программа вылетает

            /*try
            {
                string a = null;
                a.ToUpper();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }*/

            // 4.
            try
            {
                IConvertible conv = true;
                Char ch = conv.ToChar(null);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            // 5.
            try
            {
                var a = 5;
                if (a == 5)
                    throw new ArgumentException("Argument exception_");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            // 6.
            try
            {
                StreamReader str = new StreamReader("file.txt");
                var text = str.ReadToEnd();

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            // 7.
            try
            {
                var b = int.Parse("kdkoedeok");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            // 8.
            try
            {
                StreamReader str = new StreamReader("files//file.txt");
                var text = str.ReadToEnd();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
           // пока все, но скоро будет еще, я уверена :)
        }
    }
}
