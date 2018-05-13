using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Programming_Baiscs___3th_September
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine()); // 9:14
            double length = double.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());

            double covers = tables * (length + (2 * 0.30)) * (widht + (2 * 0.30));
            double cares = tables * (length / 2) * (length / 2);
            double priceUSD = ((covers * 7) + (cares * 9));
            double priceBGN = priceUSD * 1.85;
            Console.WriteLine($"{priceUSD:f2} USD");
            Console.WriteLine($"{priceBGN:f2} BGN");

        }
    }
}
