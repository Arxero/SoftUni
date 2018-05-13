using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int addedMinutes = minutes + 64;
            if (addedMinutes > 59)
            {
                hours = hours + 1;
                addedMinutes = addedMinutes - 60;
                if (hours >= 24)
                { hours = hours - 24; }
            }
                Console.WriteLine($"{hours}:{addedMinutes:d2}");
            }
        }
    }
