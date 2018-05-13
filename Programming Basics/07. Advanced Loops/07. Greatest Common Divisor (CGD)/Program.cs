using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // 24
            int b = int.Parse(Console.ReadLine()); // 16

            while (b !=0)
            {
                int newB = a % b; // 8
                a = b; // 16
                b = newB; // 8
            }
            Console.WriteLine(a);
        }
    }
}
