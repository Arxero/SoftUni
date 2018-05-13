using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int input = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> answer = new List<int>();

            foreach (int item in numbers)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    answer.Add(item);
                }
                answer.Sort((a, b) => b.CompareTo(a));
            }
            Console.WriteLine(string.Join(" ", answer));

        }
    }
}
