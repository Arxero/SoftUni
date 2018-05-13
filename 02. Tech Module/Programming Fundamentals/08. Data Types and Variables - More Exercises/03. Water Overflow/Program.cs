using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int litersSum = 0;
            int litersSum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                litersSum += liters;
                

                if (litersSum < byte.MaxValue)
                {
                    litersSum2 += liters;
                }
                if (litersSum > byte.MaxValue)
                {
                    litersSum -= liters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(litersSum2);

            //try
            //{
            //    byte n = byte.Parse(Console.ReadLine());

            //    for (int i = 0; i < n; i++)
            //    {
            //        byte liters = byte.Parse(Console.ReadLine());
            //        litersSum = liters;
            //        Console.WriteLine(litersSum);
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Insufficient capacity!");
            //}

        }
    }
}
