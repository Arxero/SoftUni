using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] sum = new int[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                char[] toChar = input[i].ToString().Reverse().ToArray();
                string toString = "";
                for (int k = 0; k < toChar.Length; k++)
                {
                    toString += toChar[k].ToString();
                }
                int toInt = int.Parse(toString);
                sum[i] = toInt;
            }
            Console.WriteLine(sum.Sum());
        }
    }
}
