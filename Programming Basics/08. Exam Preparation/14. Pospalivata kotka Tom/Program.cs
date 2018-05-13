using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Pospalivata_kotka_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysOff = double.Parse(Console.ReadLine());

            double daysOffCalculation = daysOff * 127;
            double workDays = 365 - daysOff;
            double workDaysFinal = workDays * 63;
            double finalCalculation1 = workDaysFinal + daysOffCalculation;
            double finalCalculation = Math.Abs(30000 - finalCalculation1);
            double intoHours = finalCalculation / 60;
            double intoMinute = finalCalculation % 60;

            if (30000 > finalCalculation1)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(intoHours):f0} hours and {intoMinute} minutes less for play");
            }
            else 
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(intoHours):f0} hours and {Math.Abs(intoMinute)} minutes more for play");
            }
            
            
        }
    }
}
