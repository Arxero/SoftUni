using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001f;
            double substract = Math.Max(a, b) - Math.Min(a, b);
            bool equal = true;

            if (eps <= substract)
            {
                equal = false;
            }
            Console.WriteLine(equal);
        }
    }
}
