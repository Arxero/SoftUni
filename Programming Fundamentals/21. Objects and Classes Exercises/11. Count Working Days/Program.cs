using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _11.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2017, 01, 01),
                new DateTime(2017, 03, 03),
                new DateTime(2017, 05, 01),
                new DateTime(2017, 05, 06),
                new DateTime(2017, 05, 24),
                new DateTime(2017, 09, 06),
                new DateTime(2017, 09, 22),
                new DateTime(2017, 11, 01),
                new DateTime(2017, 12, 24),
                new DateTime(2017, 12, 25),
                new DateTime(2017, 12, 26),
            };
            int counter = 0;
            for (DateTime i = startDate; i < endDate; i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday || i.DayOfWeek != DayOfWeek.Sunday || !holidays.Contains(i))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
