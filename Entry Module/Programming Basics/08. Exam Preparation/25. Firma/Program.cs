using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine()); // 4:25
            int availableDays = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double actuallhours = (availableDays * 0.90) * 8;
            double peopleWorking = workers * (2 * availableDays);
            double totalHours = actuallhours + peopleWorking;
            double hoursLeft = Math.Abs(totalHours - neededHours);
            if (totalHours >= neededHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(hoursLeft)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(hoursLeft)} hours needed.");
            }

            
        }
    }
}
