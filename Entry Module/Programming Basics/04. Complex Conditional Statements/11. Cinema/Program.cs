using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0;
            double seats = rows * columns;        

            if (projection == "Premiere")
            {
                price = 12.00;
            }
            else if (projection == "Normal")
            {
                price = 7.50;
            }
            else if (projection == "Discount")
            {
                price = 5.00;
            }
            double money = price * seats;
            Console.WriteLine($"{money:f2} leva");
        }
    }
}
