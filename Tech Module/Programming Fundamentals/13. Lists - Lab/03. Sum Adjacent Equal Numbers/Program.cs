using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    numbers[i] += numbers[i - 1];
                    numbers.Remove(numbers[i - 1]);
                    i = 0;
                }
                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
