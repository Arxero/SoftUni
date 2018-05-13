using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {"-"}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            DateTime date = new DateTime(int.Parse(input[2]), int.Parse(input[1]), int.Parse(input[0]));
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
