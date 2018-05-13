using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int column = 1; column <= n; column++)
            {
                for (int i = 0; i < column; i++)
                {
                    Console.Write($"{column} ");
                }
                Console.WriteLine();
            }
        }
    }
}
