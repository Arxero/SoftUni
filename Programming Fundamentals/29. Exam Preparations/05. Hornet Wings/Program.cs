using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            int wingFlaps = 1000;
            int wingFlapsPersecond = 100;

            double distance = (N / wingFlaps) * M;
            double time = N / wingFlapsPersecond;
            double timeRest = N / P * 5;
            double timeTotal = time + timeRest;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{timeTotal} s.");
        }
    }
}
