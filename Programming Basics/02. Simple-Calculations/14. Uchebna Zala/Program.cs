using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Uchebna_Zala
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine()) * 100;
            double w = double.Parse(Console.ReadLine()) * 100;
            int workplace_height = 120;
            int workplace_widht = 70;
            double solution = (int) (h / workplace_height);
            double solution2 = (int) (w - 100) / workplace_widht;
            Console.WriteLine("{0}", (solution*solution2)-3);

        }
    }
}
