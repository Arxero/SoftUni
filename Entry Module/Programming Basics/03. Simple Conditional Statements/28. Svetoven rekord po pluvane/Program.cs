using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Svetoven_rekord_po_pluvane
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double swimmingDistance = meters * timeForMeter;
            double devidedSeconds = Math.Floor(meters / 15);
            double addedSeconds = devidedSeconds * 12.5;
            double summedTime = swimmingDistance + addedSeconds; //31250


            if (summedTime >= record)
            {
                double neededTime = summedTime - record; //20786
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {summedTime:f2} seconds.");
            }
        }
    }
}
