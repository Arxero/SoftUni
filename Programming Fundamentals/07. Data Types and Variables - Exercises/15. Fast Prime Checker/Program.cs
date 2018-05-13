using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int counterSum = 0;
            for (int prime = 0; prime <= n; prime++)
            {
                bool lamp = true;
                for (int range = 2; range <= Math.Sqrt(prime); range++)
                {
                    if (prime % range == 0)
                    {
                        lamp = false;
                        break;
                    }
                    
                }
                counter++;
                counterSum += counter;
                if (counterSum > 3)
                {
                    Console.WriteLine($"{prime} -> {lamp}");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
