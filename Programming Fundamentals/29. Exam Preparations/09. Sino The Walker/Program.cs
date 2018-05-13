using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "HH:mm:ss", null);
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int seconds = int.Parse(Console.ReadLine()) % 86400;

            long timeToAdd = steps * seconds;

            string result = date.AddSeconds(timeToAdd).ToString("HH:mm:ss");
            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
