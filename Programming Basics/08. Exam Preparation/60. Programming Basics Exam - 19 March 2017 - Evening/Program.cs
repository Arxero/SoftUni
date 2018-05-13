using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60.Programming_Basics_Exam___19_March_2017___Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            double vineyard = double.Parse(Console.ReadLine()); // 11:00
            double production = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double grape = vineyard * production;
            double wasteAmount = grape - waste;

            double rakia = wasteAmount * 0.45;
            double letersVine = rakia / 7.5;
            double earnings = letersVine * 9.8;
            Console.WriteLine($"{earnings:f2}");
            double forSale = (wasteAmount * 0.55) * 1.5;
            Console.WriteLine($"{forSale:f2}");

        }
    }
}
