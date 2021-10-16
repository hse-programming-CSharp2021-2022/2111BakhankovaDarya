using System;

namespace _6._1
{
    class Program
    {
        /// <summary>
        /// удаление четных, сжатие по условию, вывод.
        /// </summary>
        /// <param name="arr"></param>
        public static void MyMethod(int[] arr)
        {
            int n = arr.Length;
            //удаление четных.
            for (int i = 0; i < n; i++)
                if (arr[i] % 2 == 0)
                {
                    for (int j = i; j < n - 1; j++)
                        arr[j] = arr[j + 1];
                    n--;
                    i--;
                }
            //вывод массива без четных для упрощения проверки сжатия.
            /*for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i]);*/
            //сжатие.
            for (int i = 0; i < n - 1; i++)
            {
                if ((arr[i] + arr[i + 1]) % 3 == 0)
                {
                    arr[i] = arr[i] * arr[i + 1];
                    for (int j = i + 1; j < n - 1; j++)
                        arr[j] = arr[j + 1];
                    n--;
                }
            }
            //вывод результата.
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i]);
        }
        /// <summary>
        /// точка входа.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //получение n.
            Console.WriteLine("n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[n]; //{ 1, 2, 4, 2, 7, 1, 2, 1 }
            //генерация массива.
            Random rnd = new();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-10, 11);
            //вывод сгенерированного массива.
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine();
            //обработка.
            MyMethod(arr);
        }
    }
}
