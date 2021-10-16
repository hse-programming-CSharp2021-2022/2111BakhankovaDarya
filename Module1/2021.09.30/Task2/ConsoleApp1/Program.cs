//задачка намбер 2

using System;
namespace MyProject
{
    class Program
    {
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 101);
            int[] arr = new int[99];
            for (int i = 0; i < 99; i++)
            {
                if (i == a)
                    continue;
                else arr[i] = i;
            }
            Array.Sort(arr, (a, b) =>
            {
                return rnd.Next(-1, 2);
            });
            Print(arr);
            int[] arr1 = new int[99];
            for (int i = 0; i < 99; i++)
            {
                arr1[arr[i]] = 1;
            }
            Console.WriteLine();
            for (int i = 0; i < 99; i++)
            {
                if (arr1[i] == 0)
                    Console.WriteLine("result: " + i);
            }
        }
    }
}