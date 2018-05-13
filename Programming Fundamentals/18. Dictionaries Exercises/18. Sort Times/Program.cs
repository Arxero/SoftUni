using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<string> result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string time = input[i];
                DateTime times = DateTime.ParseExact(time, "HH:mm", CultureInfo.InvariantCulture);
                string date = times.ToString("HH:mm");
                result.Add(date);
            }
            var list = result.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
