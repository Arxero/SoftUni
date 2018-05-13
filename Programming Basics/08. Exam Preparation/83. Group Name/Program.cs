using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char A = char.Parse(Console.ReadLine()); // 11:06
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 65; i <= A; i++)
            {
                for (int j = 97; j <= a; j++)
                {
                    for (int k = 97; k <= b; k++)
                    {
                        for (int l = 97; l <= c; l++)
                        {
                            for (int m = 0; m <= num; m++)
                            {
                                //Console.WriteLine($"{(char)i}{(char)j}{(char)k}{(char)l}{m}");
                                if (i == A && j == a && k == b && l == c && m == num)
                                {
                                    Console.WriteLine($"{counter}");
                                    return;
                                }
                                counter++;
                            }
                        }
                    }
                }
            }
        }
    }
}
