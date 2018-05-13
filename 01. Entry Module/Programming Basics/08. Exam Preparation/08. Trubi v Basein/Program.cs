using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trubi_v_Basein
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine()); // 5:29
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double firsPipe = Math.Truncate(P1 * hours);
            double secondPipe = Math.Truncate(P2 * hours);
            double allPipes = firsPipe + secondPipe;
            double howFull = allPipes / 10;
            double firstPercentage = 100 * firsPipe / allPipes;
            double secondPercentage = 100 * secondPipe / allPipes;
            if (V >= allPipes)
            {
                Console.WriteLine($"The pool is {howFull}% full. Pipe 1: {(int)firstPercentage}%. Pipe 2: {(int)secondPercentage}%.");
            }
            else if (V <= allPipes)
            {
                double overflow = (allPipes - V);
                Console.WriteLine($"For {hours} hours the pool overflows with {overflow:f1} liters.");
            }
        }
    }
}
