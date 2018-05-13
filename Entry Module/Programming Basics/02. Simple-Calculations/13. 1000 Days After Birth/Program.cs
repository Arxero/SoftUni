using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string BirthDate = Console.ReadLine();
            string format = "dd-MM-yyyy";
            string thetime = "hh.mm.ss";
            DateTime time = DateTime.ParseExact(BirthDate, format, null);
            Console.WriteLine(time.AddDays(999).ToString(format));
            Console.WriteLine("{0}", DateTime.Now.ToString(thetime));

        }
    }
}
