using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49.Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine()); // 10:26
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double workTime = workers * days * 8;
            double isItEnough = workTime - hours;
            double neededHours = hours - workTime;
            double penalties = neededHours * days;

            if (workTime > hours)
            {
                Console.WriteLine($"{isItEnough} hours left");
            }
            else
            {
                Console.WriteLine($"{neededHours} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }
        }
    }
}
