using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 11:15

            double from0to9 = .0;
            double from10to19 = .0;
            double from20to29 = .0;
            double from30to39 = .0;
            double from40to50 = .0;
            double invalid = 0;
            double result = .0;


            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());

                if (m >= 0 && m <= 9)
                {
                    from0to9++;
                    result = result + (m * 0.20);
                }
                else if (m >= 10 && m <= 19)
                {
                    from10to19++;
                    result = result + (m * 0.30);
                }
                else if (m >= 20 && m <= 29)
                {
                    from20to29++;
                    result =  result + (m * 0.40);
                }
                else if (m >= 30 && m <= 39)
                {
                    from30to39++;
                    result = result + 50;
                }
                else if (m >= 40 && m <= 50)
                {
                    from40to50++;
                    result = result + 100;
                }
                else if (m < 0 || m > 50)
                {
                    result = result / 2;
                    invalid++;
                }

            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(from0to9 / n) * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(from10to19 / n) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(from20to29 / n) * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(from30to39 / n) * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(from40to50 / n) * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(invalid / n) * 100:f2}%");
        }
    }
}
