using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char checker = char.Parse(Console.ReadLine());

            int counter = 0;

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    for (int c = start; c <= end; c++)
                    {
                        
                        if (a != checker && b != checker && c != checker)
                        {
                            counter++;
                            Console.Write($"{(char)a}{(char)b}{(char)c} ");
                        }
                        
                    }

                }
            }
            Console.WriteLine(counter);
        }
    }
}
