using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Programming_Basics_Exam___18_December_2016___Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = int.Parse(Console.ReadLine()); // 5:00
            int time = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            double distance = speed * (time / 60.0);
            double distance2Percent = speed + (speed * 0.10);
            double distance2 = distance2Percent * (time2 / 60.0);
            double distance3 = (distance2Percent - (distance2Percent * 0.05)) * (time3 / 60.0);
            double total = distance + distance2 + distance3;
            Console.WriteLine($"{total:f2}");
        }
    }
}
