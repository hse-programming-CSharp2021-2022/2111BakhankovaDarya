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
            //удаленный
            int a = rnd.Next(1, 101);
            //Console.WriteLine(a);
            //дважды
            int b = rnd.Next(1, 101);
            
            int[] arr = new int[100];
            for (int i = 0; i < 99; i++)
            {
                if (i == a)
                    continue;
                else arr[i] = i;
            }
            arr[99] = b;
            //перемешиваем массив.
            Array.Sort(arr, (a, b) =>
            {
                return rnd.Next(-1, 2);
            });
            Print(arr);

            int[] arr1 = new int[100];
            for (int i = 0; i < 99; i++)
            {
                if (arr[i] != 0)
                    arr1[arr[i]]++;
            }
            Console.WriteLine();
            for (int i = 0; i < 99; i++)
            {
                if (arr1[i] == 2)
                    Console.WriteLine("result: " + i);
            }
        }
    }
}