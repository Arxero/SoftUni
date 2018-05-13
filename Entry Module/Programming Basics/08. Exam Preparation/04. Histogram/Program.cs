using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 5:40

            double percentages = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int numebrsHistogram = int.Parse(Console.ReadLine());

                if (numebrsHistogram < 200)
                {
                    p1++;
                }
                else if (numebrsHistogram >= 200 && numebrsHistogram <= 399)
                {
                    p2++;
                }
                else if (numebrsHistogram >= 400 && numebrsHistogram <= 599)
                {
                    p3++;
                }
                else if (numebrsHistogram >= 600 && numebrsHistogram <= 799)
                {
                    p4++;
                }
                else if (numebrsHistogram >= 800)
                {
                    p5++;
                }
            }
            double p1Calculation = p1 / n * 100;
            double p2Calculation = p2 / n * 100;
            double p3Calculation = p3 / n * 100;
            double p4Calculation = p4 / n * 100;
            double p5Calculation = p5 / n * 100;
            Console.WriteLine($"{p1Calculation:f2}%");
            Console.WriteLine($"{p2Calculation:f2}%");
            Console.WriteLine($"{p3Calculation:f2}%");
            Console.WriteLine($"{p4Calculation:f2}%");
            Console.WriteLine($"{p5Calculation:f2}%");
        }
    }
}
