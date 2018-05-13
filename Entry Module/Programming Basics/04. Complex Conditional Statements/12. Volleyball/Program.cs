using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double weekendsSofia = 48 - h; // 46
            double saturdayGames = weekendsSofia * 3.0 / 4; //34.5
            double holidayGames = p * 2.0 / 3; //3.33
            double summedGames = saturdayGames + h + holidayGames; //39.83
            if (typeOfYear == "leap")
            {
                double percentage = summedGames * 0.15;
                double gamesForYear = summedGames + percentage;
                Console.WriteLine($"{Math.Floor(gamesForYear)}");
            }
            else if (typeOfYear == "normal")
            {
                Console.WriteLine($"{Math.Floor(summedGames)}");
            }
        }
    }
}
