using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long M = long.Parse(Console.ReadLine());
            long Y = long.Parse(Console.ReadLine());

            decimal percentage = N * 0.5m;
            //Console.WriteLine(percentage);
            long count = 0;
            long substracting = 0;

            while (N >= M)
            {
                substracting = N - M;
                count++;
                N = substracting;
                if (N == percentage && Y > 0)
                {
                    N = N / Y;
                }
            }
            Console.WriteLine($"{N}");
            Console.WriteLine($"{count}");
        }
    }
}
