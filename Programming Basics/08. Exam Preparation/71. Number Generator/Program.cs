using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine()); // 4:52
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            for (int a = M; a >= 1; a--)
            {
                for (int b = N; b >= 1; b--)
                {
                    for (int c = L; c >= 1; c--)
                    {
                        int num = int.Parse(a.ToString() + b.ToString() + c.ToString());
                        if (num % 3 == 0)
                        {
                            special = special + 5;
                        }
                        else if (num % 10 == 5)
                        {
                            special = special - 2;
                        }
                        else if (num % 2 == 0)
                        {
                            special = special * 2;
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
