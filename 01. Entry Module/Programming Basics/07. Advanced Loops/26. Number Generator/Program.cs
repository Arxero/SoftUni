using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine()); // 3:42
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());


            for (int first = M; first >= 1; first--)
            {
                for (int second = N; second >= 1; second--)
                {
                    for (int third = L; third >= 1; third--)
                    {
                        int number = first * 100 + second * 10 + third;
                        if (number % 3 == 0)
                        {
                            special += 5;
                        }
                        else if (number % 10 == 5)
                        {
                            special -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            special *= 2;
                        }
                        if (special >= control)
                        {
                            break;
                        }
                    }
                    if (special >= control)
                    {
                        break;
                    }
                }
                if (special >= control)
                {
                    break;
                }
            }
            if (special >= control)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {special}.");

            }
            else
            {
                Console.WriteLine($"No! {special} is the last reached special number.");

            }
        }
    }
}
