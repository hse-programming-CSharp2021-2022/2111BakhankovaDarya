using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static bool Vowel(char x)
        {

            string vowels = "aoeyuiAOYUEI";
            for (int i = 0; i < 10; i++)
                if (x == vowels[i])
                    return true;
            return false;
        }
        static void Main(string[] args)
        {
            //string sb = Console.ReadLine();
            string sb = "Let it be; All you need is love; Dizzy Miss Lizzy";

            string[] spoint = sb.Split(";");
            string[][] sBySpace = new string[spoint.Length][];
            for(int i=0; i<spoint.Length; i++)
            {
                sBySpace[i] = spoint[i].Split(" ");
            }
            
            //эта часть кода выдает ошибку почему-то.
            /*for (int i = 0; i < sBySpace.Length; i++)
                for (int j = 0; j < sBySpace[i].Length; j++)
                    sBySpace[i][j][0].ToString().ToUpper();*/

            
            for (int i=0; i<sBySpace.Length; i++)
            {
                
                for(int j=0; j<sBySpace[i].Length; j++)
                {
                    
                    for(int l=0; l<sBySpace[i][j].Length; l++)
                    {
                        if (Vowel(sBySpace[i][j][l]))
                        {
                            Console.Write(sBySpace[i][j][l]);
                            break;
                        }
                        else
                            Console.Write(sBySpace[i][j][l]);
                    } 
                }
                Console.WriteLine();
            }
        }
    }
}