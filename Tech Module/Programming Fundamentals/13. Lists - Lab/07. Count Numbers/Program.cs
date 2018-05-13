using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int max = nums.Max();
            int[] counts = new int[max + 1];
            foreach (var x in nums)
            {
                counts[x]++;
            }
            //Console.WriteLine(string.Join(" ", nums));
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] !=0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
        }
    }
}
