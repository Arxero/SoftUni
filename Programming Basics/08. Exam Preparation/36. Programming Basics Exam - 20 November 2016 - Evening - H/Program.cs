using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Programming_Basics_Exam___20_November_2016___Evening___H
{
    class Program
    {
        static void Main(string[] args)
        {
            double room = double.Parse(Console.ReadLine()); // 9:45
            double kitchen = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double room2 = (room * 0.10) + room;
            double room3 = (room2 * 0.10) + room2;
            double bathroom = room / 2;
            double total = (((room + kitchen + room2 + room3 + bathroom) * 0.05) + (room + kitchen + room2 + room3 + bathroom)) * price;

            Console.WriteLine($"{total:f2}");
        }
    }
}
