using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73.Svetoven_Record_po_Pluvane
{
    class Program
    {
        static void Main(string[] args)
        {
            double seconds = double.Parse(Console.ReadLine()); // 4:12
            double meteres = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double distance = meteres * time;
            double addedTime = Math.Floor(meteres / 15) * 12.5;
            double totalTime = distance + addedTime;
            double isItEnough = totalTime - seconds;

            if (seconds <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {isItEnough:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}
