using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Pospalivata_kotka_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());

            int tomPlayTime = 30000;
            int tomPlayTimeWork = 63;
            int tomPlayTimeFreeDays = 127;
            int days = 365;

            int freeDaysInMinutes = freeDays * tomPlayTimeFreeDays;
            int playDays = (days - freeDays) * tomPlayTimeWork + freeDays * 127;

            if (playDays <= tomPlayTime)
            {

                int normDifference = tomPlayTime - playDays;
                double convertingToHours = normDifference / 60;
                double convertingToMinutes = normDifference % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{convertingToHours} hours and {convertingToMinutes} minutes less for play");
            }
            else
            {
                int normDifference = playDays - tomPlayTime;
                double convertingToHours = normDifference / 60;
                double convertingToMinutes = normDifference % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{convertingToHours} hours and {convertingToMinutes} minutes more for play");
            }
        }
    }
}
