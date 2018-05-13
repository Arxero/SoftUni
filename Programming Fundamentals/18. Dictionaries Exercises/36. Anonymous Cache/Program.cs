using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();


            while (input != "thetinggoesskrra")
            {
                string[] splitter = input.Split(new[] { " ", "-", ">", "|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitter.Length == 1)
                {
                    string dataSet = splitter[0];

                    //If you receive only a dataSet you should add it
                    if (!results.ContainsKey(dataSet))
                    {
                        results.Add(dataSet, new Dictionary<string, long>());
                        if (cache.ContainsKey(dataSet))
                        {
                            foreach (var cach in cache.Where(x => x.Key == dataSet))
                            {
                                foreach (var dataKey in cach.Value)
                                {
                                    results[dataSet].Add(dataKey.Key, dataKey.Value);
                                }
                                
                            }
                            
                        }
                    }
                }
                else
                {
                    string dataSet = splitter[2];
                    string dataKey = splitter[0];
                    long dataSize = long.Parse(splitter[1]);

                    //If you receive a dataKey and a dataSize, but the given dataSet does NOT exist, 
                    if (!results.ContainsKey(dataSet))
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                    }
                    //If you receive a dataKey and a dataSize, you should add them to the given dataSet.
                    else
                    {
                        results[dataSet].Add(dataKey, dataSize);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var result in results.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Values.Sum()}");
                foreach (var dataKey in result.Value)
                {
                    Console.WriteLine($"$.{dataKey.Key}");
                }
                break;
            }
        }
    }
}
