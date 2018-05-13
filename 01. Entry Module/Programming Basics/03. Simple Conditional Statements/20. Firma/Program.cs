using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            double overtime = 2;
            double trainingTimePercentage = days * 0.1;
            double trainingTimePercentageSubstracted = (days - trainingTimePercentage) * 8;
            double overtimeWork = people * (overtime * days);
            double summedHours = trainingTimePercentageSubstracted + overtimeWork;
            double hoursLeft = Math.Floor(summedHours - hours);

            if (summedHours >= hours)
            {
                Console.Write("Yes!");
                Console.WriteLine($"{hoursLeft} hours left.");
            }
            else
            {
                double hoursNotEnough = Math.Ceiling(hours - summedHours);
                Console.WriteLine($"Not enough time!{hoursNotEnough} hours needed."); 
            }

        }
    }
}
