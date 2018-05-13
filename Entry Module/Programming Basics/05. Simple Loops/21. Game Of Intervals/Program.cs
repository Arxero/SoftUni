using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double moves = double.Parse(Console.ReadLine()); // 12:52

            double result = 0;
            int from0to9 = 0;
            int from10to19 = 0;
            int from20to29 = 0;
            int from30to39 = 0;
            int from40to49 = 0;
            int invalid = 0;

            for (int i = 0; i < moves; i++)
            {
                int nextMove = int.Parse(Console.ReadLine());

                if (nextMove >= 0 && nextMove <= 9)
                {
                    result = result + (nextMove * 0.20);
                    from0to9++;
                }
                else if (nextMove >= 10 && nextMove <= 19)
                {
                    result = result + (nextMove * 0.30);
                    from10to19++;
                }
                else if (nextMove >= 20 && nextMove <= 29)
                {
                    result = result + (nextMove * 0.40);
                    from20to29++;
                }
                else if (nextMove >= 30 && nextMove <= 39)
                {
                    result += 50;
                    from30to39++;
                }
                else if (nextMove >= 40 && nextMove <= 50)
                {
                    result += 100;
                    from40to49++;
                }
                else if (nextMove <0 || nextMove > 50)
                {
                    result = result / 2;
                    invalid++;
                }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {from0to9 / moves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {from10to19 / moves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {from20to29 / moves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {from30to39 / moves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {from40to49 / moves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalid / moves * 100:f2}%");


        }
    }
}
