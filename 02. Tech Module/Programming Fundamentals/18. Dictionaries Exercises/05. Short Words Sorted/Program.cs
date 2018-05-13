using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ".", ",", ":", ";", "(", ")", "[", "]", "\"", "'", "\\", "/", "!", "?", " "}, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length < 5).OrderBy(x => x).Select(x => x.ToLower()).Distinct().ToArray();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
