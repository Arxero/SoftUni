using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[n.Length];

            for (int r = 1; r <= k; r++)
            {
                int[] rotation = new int[n.Length];
                rotation[0] = n[n.Length - 1];
                for (int i = 1; i < rotation.Length; i++)
                {
                    rotation[i] += n[i - 1];
                    
                }
                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += rotation[j];
                }
                n = rotation;
            }
            Console.WriteLine(string.Join(" ", sum));
            
        }
    }
}
