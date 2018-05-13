using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int cups = int.Parse(Console.ReadLine()); // 8:49
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double calculation = workers * days * 8;
            double cupsMaded = Math.Floor(calculation / 5);
            double substraction = Math.Abs(cups - cupsMaded);
            double losses = substraction * 4.2;
            if (cupsMaded <= cups)
            {
                Console.WriteLine($"Losses: {losses:f2}");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(losses):f2} extra money");
            }
        }
    }
}
