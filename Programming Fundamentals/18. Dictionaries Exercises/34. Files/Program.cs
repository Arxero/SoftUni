using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            Dictionary<string, long> results = new Dictionary<string, long>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }

            string[] query = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string extension = query[0];
            string root = query[2];

            for (int i = 0; i < list.Count; i++)
            {
                string[] splitter = list[i].Split(new[] { ";", "\\" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitter[0] == root)
                {

                    string file = splitter[splitter.Length - 2];
                    long size = long.Parse(splitter[splitter.Length - 1]);

                    char[] extensionFileChars = file.Skip(file.Length - extension.Length - 1).ToArray();
                    string extensionFile = string.Join("", extensionFileChars);

                    if (extensionFile == ("." + extension))
                    {
                        if (!results.ContainsKey(file))
                        {
                            results.Add(file, size);
                        }
                        else
                        {
                            results[file] = size;
                        }
                        
                    }
                }
            }
            if (results.Any())
            {
                foreach (var result in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{result.Key} - {result.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
