using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _22.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> results = new Dictionary<string, string>();
            string pattern = @"^[A-Z]{2}[0-9]{4}[A-Z]{2}$";

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "register")
                {
                    string username = input[1];
                    Match match = Regex.Match(input[2], pattern);

                    if (match.Success)
                    {
                        string licensePlate = input[2];

                        if (!results.ContainsKey(username))
                        {
                            if (results.ContainsValue(licensePlate))
                            {
                                //Console.WriteLine($"ERROR: license plate {input[2]} is busy");
                            }
                            else
                            {
                                results.Add(username, licensePlate);
                                Console.WriteLine($"{username} registered {input[2]} successfully");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: license plate {input[2]} is busy");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {input[2]}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (!results.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                    else
                    {
                        results.Remove(input[1]);
                        Console.WriteLine($"user {input[1]} unregistered successfully");
                    }
                }

            }
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} => {result.Value}");
            }

        }
    }
}
