using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double currency = double.Parse(Console.ReadLine());
            double BGN = currency * 1.79549;
            Console.WriteLine(Math.Round(BGN, 2) + " BGN");
        }
    }
}
