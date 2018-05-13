using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double time = workers * days * 8;
            double leftTime = time - hours;

            if (time >= hours)
            {
                Console.WriteLine($"{leftTime} hours left");
            }
            else
            {
                double neededTime = hours - time;
                Console.WriteLine($"{neededTime} overtime");
                double penalties = neededTime * days;
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
