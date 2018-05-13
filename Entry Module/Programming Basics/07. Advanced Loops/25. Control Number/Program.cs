using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // 12:51
            int M = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            int ass = 0;
            int counter = 0;
            bool lamp = false;

            for (int first = 1; first <= N; first++)
            {
                for (int second = M; second >= 1; second--)
                {
                    int cycle = ass + first * 2 + second * 3;
                    ass = cycle;
                    counter++;
                    if (cycle >= controlNum)
                    {
                        Console.WriteLine($"{counter} moves");
                        Console.WriteLine($"Score: {cycle} >= {controlNum}");
                        lamp = true;
                        break;
                    }
                }
                if (lamp == true)
                {
                    break;
                }
            }
            if (lamp == false)
            {
                Console.WriteLine($"{counter} moves");
            }
        }
    }
}
