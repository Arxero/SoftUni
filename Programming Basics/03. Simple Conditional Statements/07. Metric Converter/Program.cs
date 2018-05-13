using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string from = (Console.ReadLine());
            string to = (Console.ReadLine());

            /*double meter = 1;
            double mm = 1000;
            double cm = 100;
            double miles = 0.000621371192;
            double inches = 39.3700787;
            double km = 0.001;
            double feet = 3.2808399;
            double yd = 1.0936133;*/

            if (from == "mm")
            {
                if (to == "cm")
                    Console.WriteLine(input / 10);
                if (to == "miles")
                    Console.WriteLine( input * 0.000621371);
            }



        }
    }
}
