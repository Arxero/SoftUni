using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLev = int.Parse(Console.ReadLine());
            int twoLevs = int.Parse(Console.ReadLine());
            int threeLevs = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int edilev = 0;
            int dvaleva = 0;
            int trileva = 0;

            for (int i = 0; i <= oneLev; i++)
            {
                for (int j = 0; j <= twoLevs; j++)
                {
                    for (int k = 0; k <= threeLevs; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");

                        }
                    }
                }
            }

        }
    }
}
