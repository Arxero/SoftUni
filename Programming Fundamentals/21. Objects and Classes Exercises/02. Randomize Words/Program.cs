using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int num = rnd.Next(0, input.Length);
                int num2 = rnd.Next(0, input.Length);

                string word = input[num];
                input[num] = input[num2];
                input[num2] = word;
            }
            Console.WriteLine(string.Join("\r\n", input));
        }
    }
}
