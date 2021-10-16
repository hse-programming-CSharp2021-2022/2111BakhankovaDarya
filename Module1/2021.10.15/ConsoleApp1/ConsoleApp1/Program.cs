//офлайн семинар 2021.10.16
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
	static void Print (IEnumerable<int> str)
    {
		Console.WriteLine();
		foreach (int i in str)
			Console.Write(i + " ");
		/*if (str.ToArray().Length == 0)
			Console.Write("nothing");*/
    }
	static void Print(int[] str)
	{
		Console.WriteLine();
		foreach (int i in str)
			Console.Write(i + " ");
	}
	static bool Polindrom(int a, int n)
    {
		int[] arr = new int[n];
		int i = 0;
        while (a > 0)
        {
			arr[i] = a % 10;
			i++;
			a /= 10;
		}
		int k = 0;
		for (int j = 0; j < arr.Length; j++)
			if (arr[j] == arr[arr.Length - j-1])
				k++;
		return k == arr.Length;
    }
	static void Main(string[] args)
	{
		/*string[] names = { "CDCF", "klkl", "klllkl", "5655" };
		List <string> str = new List<string>();

		for(int i=0; i<names.Length; i++)
        {
			if (names[i].ToUpper().StartsWith("A"))
				str.Add(names[i]);
        }

		var str2 = (from s in names
				   where s.ToUpper().StartsWith("A")
				   orderby s descending
				   select s).ToArray();*/

		Console.Write("n: ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		Random rnd = new Random();
		for (int i = 0; i < n; i++)
			arr[i] = rnd.Next(1, 10000 + 1);
		Print(arr);
		//1
		IEnumerable<int> str1 = from s in arr
				   where (s > 9 && s < 101 && s % 3 == 0)
				   select s;
		Print(str1);
		//2
		arr[2] = 12321;
		Print(arr);
		IEnumerable<int> str2 = from s in arr
								where (Polindrom(s, n))
								select s;
		Print(str2);

		/*string s = "Бык тупогуб ...";
		Regex regex = new Regex(@"туп\w*");
		var mathes = regex.Matches(s);
		foreach(Match m in matches)
        {
			Console.WriteLine(m);
        }
		string s2 = "111-111-1111";
		Regex regex2= new Regex(@"")*/

	}
}
