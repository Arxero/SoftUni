using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = Console.ReadLine().Split(new[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new Dictionary<string, Dictionary<string, List<int>>>();

            while (arr[0] != "thetinggoesskrra")
            {
                string dataKey = arr[0];
                int dataSize = int.Parse(arr[1]);
                string dataSet = arr[2];

                if (!dict.ContainsKey(dataSet))
                {
                    dict.Add(dataSet, new Dictionary<string, List<int>>());

                }


            }

        }
    }
}
