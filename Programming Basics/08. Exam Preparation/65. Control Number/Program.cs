using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65.Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 1:03
            int m = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            int result = 0;
            int totalResult = 0;
            int count = 0;
            bool lamp = false;

            for (int a = 1; a <= n; a++)
            {
                for (int b = m; b >= 1; b--)
                {
                    totalResult = result + a * 2 + b * 3;
                    result = totalResult;
                    count++;
                    if (totalResult >= control)
                    {
                        lamp = true;
                        Console.WriteLine($"{count} moves");
                        Console.WriteLine($"Score: {result} >= {control}");
                        break;
                    }

                }
                if (lamp == true)
                {
                    break;
                }
            }
            if (lamp == false)
            {
                Console.WriteLine($"{count} moves");
            }
        }
    }
}
