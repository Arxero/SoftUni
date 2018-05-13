using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int calculation = n * multiplier;

            if (multiplier > 10)
            {
                Console.WriteLine($"{n} X {multiplier} = {calculation}");
            }

            for (int i = multiplier; i <= 10; i++)
            {
                calculation = n * i;
                if (i <= 10)
                {
                    Console.WriteLine($"{n} X {i} = {calculation}");
                }
            }
        }
    }
}
