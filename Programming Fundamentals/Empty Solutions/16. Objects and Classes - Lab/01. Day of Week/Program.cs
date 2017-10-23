using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            Random rnd = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);
                string temp = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
