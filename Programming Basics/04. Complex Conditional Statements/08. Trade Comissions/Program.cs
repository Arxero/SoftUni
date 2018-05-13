using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double commission = -1;

            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500)
                    { commission = sales * 0.05; }
                else if (500 < sales && sales <= 1000)
                    { commission = sales * 0.07; }
                else if (1000 < sales && sales <= 10000)
                    { commission = sales * 0.08; }
                else if (sales > 10000)
                    { commission = sales * 0.12; }
            }
            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500)
                { commission = sales * 0.045; }
                else if (500 < sales && sales <= 1000)
                { commission = sales * 0.075; }
                else if (1000 < sales && sales <= 10000)
                { commission = sales * 0.10; }
                else if (sales > 10000)
                { commission = sales * 0.13; }
            }
            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                { commission = sales * 0.055; }
                else if (500 < sales && sales <= 1000)
                { commission = sales * 0.08; }
                else if (1000 < sales && sales <= 10000)
                { commission = sales * 0.12; }
                else if (sales > 10000)
                { commission = sales * 0.145; }
            }
            if (commission > 0)
            {
                Console.WriteLine($"{commission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
