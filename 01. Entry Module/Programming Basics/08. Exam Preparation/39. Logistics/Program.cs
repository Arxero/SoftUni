using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loads = int.Parse(Console.ReadLine()); // 10:25

            double microbuss = 0;
            double truck = 0;
            double train = 0;
            double totalTons = 0;

            for (int i = 0; i < loads; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                totalTons = totalTons + tons;
                if (tons <= 3)
                {
                    microbuss = microbuss + tons;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    truck = truck + tons;
                }
                else if (tons >= 12)
                {
                    train = train + tons;
                }
            }
            double average = (microbuss * 200 + truck * 175 + train * 120) / totalTons;
            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{microbuss / totalTons * 100:f2}%");
            Console.WriteLine($"{truck / totalTons * 100:f2}%");
            Console.WriteLine($"{train / totalTons * 100:f2}%");
        }
    }
}
