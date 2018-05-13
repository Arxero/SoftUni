using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantems = int.Parse(Console.ReadLine()); // 5:45
            int roses = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string  holiday = Console.ReadLine();

            double hrizanetmsPrice = 0;
            double rosesPrice = 0;
            double laletaPrice = 0;
             
            // season check
            if (season == "Spring" || season == "Summer")
            {
                hrizanetmsPrice = 2.00;
                rosesPrice = 4.10;
                laletaPrice = 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                hrizanetmsPrice = 3.75;
                rosesPrice = 4.50;
                laletaPrice = 4.15;
            }
            // holyday check
            double total = 0;
            if (holiday == "Y")
            {
                total = (hrizantems * hrizanetmsPrice + roses * rosesPrice + laleta * laletaPrice) + ((hrizantems * hrizanetmsPrice + roses * rosesPrice + laleta * laletaPrice) * 0.15);
            }
            else
            {
                total = hrizantems * hrizanetmsPrice +roses * rosesPrice + laleta * laletaPrice;
            }
            // discounts check
            if (laleta > 7 && season == "Spring")
            {
                total = total - (total * 0.05);
            }
            if (roses >= 10 && season == "Winter")
            {
                total = total - (total * 0.10);
            }
            if (hrizantems + roses + laleta > 20)
            {
                total = total - (total * 0.20);
            }
            double final = total + 2;
            Console.WriteLine($"{final:f2}");



        }
    }
}
