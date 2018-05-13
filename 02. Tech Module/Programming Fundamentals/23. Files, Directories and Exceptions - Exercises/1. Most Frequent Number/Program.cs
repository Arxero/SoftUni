using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] array = File.ReadAllText("input.txt").Split(' ').Select(ushort.Parse).ToArray();
            int[] count = new int[65536];

            foreach (ushort num in array)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            for (int i = 0; i < array.Length; i++)
            {
                if (count[array[i]] == maxValue)
                {
                    File.WriteAllText("output.txt", array[i].ToString());
                    
                    return;
                }
            }
        }
    }
}
