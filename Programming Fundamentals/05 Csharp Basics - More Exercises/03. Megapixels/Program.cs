using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            decimal calculatoin = (width * height) / 1000000;
            Console.WriteLine($"{width}x{height} => {Math.Round(calculatoin, 1)}MP");

        }
    }
}
