using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66.Programming_Basics_Exam___7_May_2017___Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine()); // 5:20
            double beer = double.Parse(Console.ReadLine());
            double vine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double rakiaPrice = price / 2;
            double vinePrice = rakiaPrice - (rakiaPrice * 0.40);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.80);
            double moneyRakia = rakia * rakiaPrice;
            double moneyVine = vine * vinePrice;
            double moneyBeer = beer * beerPrice;
            double moneyWhiskey = whiskey * price;
            double total = moneyRakia + moneyBeer + moneyVine + moneyWhiskey;
            Console.WriteLine($"{total:f2}");
        }
    }
}
