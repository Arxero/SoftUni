using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine()); 
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());

            int summedSeconds = firstSeconds + secondSeconds + thirdSeconds;
            int minutes = summedSeconds / 60;
            int seconds = summedSeconds % 60;

                Console.WriteLine($"{minutes}:{seconds:d2}");

        }
    }
}
