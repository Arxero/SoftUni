using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToCheck = Console.ReadLine().ToLower();
            string checker = Console.ReadLine().ToLower();

            int count = 0;
            int index = textToCheck.IndexOf(checker);
            while(index != -1)
            {
                count++;
                index = textToCheck.IndexOf(checker, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
