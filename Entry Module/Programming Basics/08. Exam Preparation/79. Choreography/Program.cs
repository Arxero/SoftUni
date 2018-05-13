using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine()); // 9:06
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsDaily = (steps / days) / steps;
            double percentage = Math.Ceiling(stepsDaily * 100);
            double stepsDancer = percentage / dancers;
            if (percentage <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsDancer:f2}% steps to be learned per day.");
            }
        }
    }
}
