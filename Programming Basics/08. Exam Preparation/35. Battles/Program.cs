using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); // 6:49
            int n2 = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    counter++;

                    if (counter >= max)
                    {
                        break;
                    }
                }
                if (counter >= max)
                    {
                        break;
                    }
            }
            Console.WriteLine();
        }
    }
}
