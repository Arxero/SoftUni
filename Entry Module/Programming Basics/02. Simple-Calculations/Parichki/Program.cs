using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parichki
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double BTC = 1168 * bitcoins;
            double USD = 1.76;
            double CYN = (0.15 * yuan) * USD;
            double EUR = 1.95;

            double solution = (BTC + CYN) / EUR;
            double percents = solution * commision / 100;
            double final_solution = solution - percents;
            Console.WriteLine("{0:F2}", final_solution);
   

        }
    }
}
