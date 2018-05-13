using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            bool lamp = false;

            for (int i = a; i <= b; i++)
            {
                for (int k = a; k <= b; k++)
                {
                    for (int j = a; j <= b; j++)
                    {
                        for (int l = a; l <= b; l++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                if (a <= i && i < k && k < j && j < l && l < m && m <= b)
                                {
                                    Console.WriteLine($"{i} {k} {j} {l} {m} ");
                                    lamp = true;
                                }
                            }
                        }
                    }
                }
            }
            if (lamp == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
