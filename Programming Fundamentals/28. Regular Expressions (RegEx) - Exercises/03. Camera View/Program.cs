using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            string pattern = @"(?<=\\|<)\w+";

            var regex = Regex.Matches(text, pattern);

            int elementsToSkip = nums[0];
            int elementsToTake = nums[1];


            //var result = regex.Skip(elementsToSkip).Take(elementsToTake).ToList();
            List<string> list = new List<string>();
            foreach (Match item in regex)
            {
                var result = item.ToString().Skip(elementsToSkip).Take(elementsToTake).ToString();
                list.Add(result);
                
            }
            //Console.WriteLine(string.Join(", ", regex));
            Console.WriteLine(string.Join(", ", list));


        }
    }
}
