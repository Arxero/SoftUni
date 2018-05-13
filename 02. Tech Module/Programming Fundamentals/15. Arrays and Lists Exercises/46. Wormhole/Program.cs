using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> input = "0 0 0 2 0 0 5".Split().Select(int.Parse).ToList();

            int count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] != 0)
                {
                    int iKeeper = i;
                    i = input[i];
                    input[iKeeper] = 0;
                }
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
