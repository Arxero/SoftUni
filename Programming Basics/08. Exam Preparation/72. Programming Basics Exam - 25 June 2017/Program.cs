using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72.Programming_Basics_Exam___25_June_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); // 4:00
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesMade = cakes * 45;
            double waflesMade = wafles * 5.80;
            double pancakesMade = pancakes * 3.20;
            double totalDay = (cakesMade + waflesMade + pancakesMade) * bakers;
            double totalCompany = totalDay * days;
            double totalNet = totalCompany - (totalCompany / 8);
            Console.WriteLine($"{totalNet:f2}");

        }
    }
}
