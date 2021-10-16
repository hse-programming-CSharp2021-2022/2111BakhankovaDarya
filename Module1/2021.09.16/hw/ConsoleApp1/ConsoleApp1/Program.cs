using System;
//2021.09.16
/*	Написать метод, преобразующий число переданное
 *	в качестве параметра в число, записанное теми же цифрами, но идущими в обратном порядке.	*/								
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //по умолчанию число целое неотрицательное.
            //могу написать и через арифметику, но так неинтересно.
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
