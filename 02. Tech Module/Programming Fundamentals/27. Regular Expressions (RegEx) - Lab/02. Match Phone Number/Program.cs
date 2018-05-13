using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            string numbers = Console.ReadLine();

            MatchCollection matchedNumbers = Regex.Matches(numbers, regex);
            var listOfNumbers = new List<string>();

            foreach (Match number in matchedNumbers)
            {
                listOfNumbers.Add(number.Value.Trim());
            }
            Console.WriteLine(string.Join(", ", listOfNumbers));
        }
    }
}
