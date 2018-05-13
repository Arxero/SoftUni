using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char beginning = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char invalidCombinarions = char.Parse(Console.ReadLine());

            int count = 0;

            for (char a = beginning; a <= end; a++)
            {
                for (char b = beginning; b <= end; b++)
                {
                    for (char c = beginning; c <= end; c++)
                    {
                        if (a != invalidCombinarions && b != invalidCombinarions && c != invalidCombinarions)
                        {
                            count++;
                            Console.Write($"{a}{b}{c} ");
                        }
                        
                    }
                }
            }
            Console.Write($"{count}");
            Console.WriteLine();
        }
    }
}
