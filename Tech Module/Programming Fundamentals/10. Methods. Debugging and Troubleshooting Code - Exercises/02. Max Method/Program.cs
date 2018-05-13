using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int max = GetMax(one, two, three);
            Console.WriteLine(max);
        }
        static int GetMax(int a, int b, int c)
        {
            int max = Math.Max(a, Math.Max(b, c));
            return max;
        }
    }
}
