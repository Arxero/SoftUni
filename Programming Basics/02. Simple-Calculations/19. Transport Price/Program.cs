using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string daytime = (Console.ReadLine());

            if (daytime == "night")
                if (n < 20)
                    Console.WriteLine(0.70 + n * 0.90);

            if (daytime == "day")
                if (n < 20)
                    Console.WriteLine(0.70 + n * 0.79);
                if (n >= 20)
                    Console.WriteLine(n * 0.09);
                if (n >= 100)
                    Console.WriteLine(n * 0.06);

        }
    }
}