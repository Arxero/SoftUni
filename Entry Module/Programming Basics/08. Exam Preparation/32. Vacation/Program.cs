using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldies = int.Parse(Console.ReadLine()); // 5:34
            int students = int.Parse(Console.ReadLine());
            int overnights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            double priceOldies = 0;
            double priceStudents = 0;

            switch (transport)
            {
                case "train":
                    if (oldies + students >= 50 )
                    {
                        priceOldies = 24.99 * 0.5;
                        priceStudents = 14.99 * 0.5;
                    }
                    else
                    {
                        priceOldies = 24.99;
                        priceStudents = 14.99;
                    }
                    
                    break;
                case "bus":
                    priceOldies = 32.50;
                    priceStudents = 28.50;
                    break;
                case "boat":
                    priceOldies = 42.99;
                    priceStudents = 39.99;
                    break;
                case "airplane":
                    priceOldies = 70.00;
                    priceStudents = 50.00;
                    break;
            }
            double transportPrice = ((oldies * priceOldies) + (students * priceStudents)) * 2;
            double overnightsPrice = overnights * 82.99;
            double commission = (transportPrice + overnightsPrice) * 0.10;
            double totalBill = transportPrice + overnightsPrice + commission;
            Console.WriteLine($"{totalBill:f2}");
        }
    }
}
