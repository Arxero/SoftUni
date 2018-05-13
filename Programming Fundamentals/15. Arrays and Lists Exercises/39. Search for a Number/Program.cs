using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int take = nums[0];
            int delete = nums[1];
            int lookFor = nums[2];

            List<int> taking = input.Take(take).ToList();
            for (int i = 0; i < delete; i++)
            {
                taking.RemoveAt(0);
            }

            if (taking.Contains(lookFor))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
