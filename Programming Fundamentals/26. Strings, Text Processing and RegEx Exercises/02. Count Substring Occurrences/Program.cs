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
            string input = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int count = 0;
            int appearance = input.IndexOf(word);

            while (appearance != -1)//if the what we are looking for is not found default answer is -1
            {
                count++;
                appearance = input.IndexOf(word, appearance + 1);
                
            }
            Console.WriteLine(count);
        }
    }
}
