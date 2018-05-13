using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Figures_with_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int week = 4;
            int daysOfWeek = 7;

            for (int currentWeek = 0; currentWeek < week; currentWeek++)
            {
                Console.WriteLine($" Week: {currentWeek + 1}");
                for (int currentDayOfWeek = 0; currentDayOfWeek < daysOfWeek; currentDayOfWeek++)
                {
                    Console.WriteLine($"   Day: {currentDayOfWeek + 1}");
                }
            }
        }
    }
}
