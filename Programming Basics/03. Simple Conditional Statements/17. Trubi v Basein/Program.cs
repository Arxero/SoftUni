using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Trubi_v_Basein
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double firstPipe = H * P1;
            double secondPipe = H * P2;
            double bothPipes = firstPipe + secondPipe;
            double fullInfoPercentage = Math.Truncate(bothPipes / V * 100);

            double firstPipePercentage = Math.Truncate(firstPipe / bothPipes * 100);
            double secondPipePercentage = Math.Truncate(secondPipe / bothPipes * 100);

            if (bothPipes <= V)
            {
                Console.WriteLine($"The pool is {fullInfoPercentage}% full. Pipe 1: {firstPipePercentage}%. Pipe 2: {secondPipePercentage}%.");
            }
            else
            {
                bothPipes = bothPipes - V;
                Console.WriteLine($"For {H} hours the pool overflows with {bothPipes:f1} liters.");
            }
        }
    }
}
