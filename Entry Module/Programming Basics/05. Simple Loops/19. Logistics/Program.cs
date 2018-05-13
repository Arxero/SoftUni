using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadsNumber = int.Parse(Console.ReadLine()); //11:50

            double allLoads = 0;
            double microbusLoads = 0;
            double truckLoads = 0;
            double trainLoads = 0;
            double price = 0;

            for (int i = 0; i < loadsNumber; i++)
            {
                double loadWeight = double.Parse(Console.ReadLine());

                allLoads = allLoads + loadWeight;

                if (loadWeight <= 3)
                {
                    microbusLoads += loadWeight;
                    price = loadWeight * 200;
                }
                else if (loadWeight >= 4 && loadWeight <= 11)
                {
                    truckLoads += loadWeight;
                    price = loadWeight * 175;
                }
                else if (loadWeight >= 12)
                {
                    trainLoads += loadWeight;
                    price = loadWeight * 120;
                }
            }
            Console.WriteLine($"{(microbusLoads * 200 + truckLoads * 175 + trainLoads * 120) / allLoads:f2}");
            Console.WriteLine($"{microbusLoads / allLoads * 100:f2}%");
            Console.WriteLine($"{truckLoads / allLoads * 100:f2}%");
            Console.WriteLine($"{trainLoads / allLoads * 100:f2}%");
        }
    }
}
