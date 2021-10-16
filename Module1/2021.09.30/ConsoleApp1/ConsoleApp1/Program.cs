//задачка намбер 1 за 2021.09.30
using System;
namespace MyProject
{
    class Program
    {
        static void Print(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("k:");
            int k = int.Parse(Console.ReadLine());
            char[] arr = new char[k];
            char[] arr_copy = new char[k];
            Random rnd = new Random();
            for (int i = 0; i < k; i++)
            {
                arr[i] = (char)rnd.Next('A', 'Z' + 1);
                arr_copy[i] = arr[i];
            }
            Print(arr);
            Console.WriteLine();
            Array.Sort(arr_copy);
            Print(arr_copy);
            Console.WriteLine();
            Array.Reverse(arr_copy);
            Print(arr_copy);
        }
    }
}
