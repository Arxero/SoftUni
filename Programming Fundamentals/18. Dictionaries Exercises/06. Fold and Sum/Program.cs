using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] left = input.Take(input.Length / 4).Reverse().ToArray();
            int[] right = input.Reverse().Take(input.Length / 4).ToArray();

            List<int> leftAndRight = new List<int>();
            leftAndRight.AddRange(left);
            leftAndRight.AddRange(right);

            int[] middle = input.Skip(left.Length).Take(left.Length * 2).ToArray();
            leftAndRight = leftAndRight.Zip(middle, (x, y) => x + y).ToList();

            Console.WriteLine(string.Join(" ", leftAndRight));
        }
    }
}
