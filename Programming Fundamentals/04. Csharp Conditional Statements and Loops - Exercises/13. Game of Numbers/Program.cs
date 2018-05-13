using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;
            int counter = 0;

            for (int i = M; i >= N; i--)
            {
                for (int j = M; j >= N; j--)
                {
                    if (i + j == magic)
                    {
                        a = i;
                        b = j;
                        break;
                    }
                    counter++;
                }
                if (a + b == magic)
                {
                    break;
                }
            }
            if (a + b == magic)
            {
                Console.WriteLine($"Number found! {a} + {b} = {magic}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
