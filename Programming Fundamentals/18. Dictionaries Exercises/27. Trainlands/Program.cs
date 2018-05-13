using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();

            while (input != "It's Training Men!")
            {
                string[] splitter = input.Split(new[] { " ", ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                

                //Creates a train
                if (splitter[1] == "->" && splitter.Length == 4)
                {
                    string train = splitter[0];
                    string wagon = splitter[2];
                    int power = int.Parse(splitter[3]);

                    if (!results.ContainsKey(train))
                    {
                        results.Add(train, new Dictionary<string, int>());
                        results[train].Add(wagon, power);
                    }
                    else
                    {
                        results[train].Add(wagon, power);
                    }
                }

                //Adds all of the wagons from the other train 
                else if (splitter[1] == "->")
                {
                    string train = splitter[0];
                    string otherTrainName = splitter[2];

                    if (!results.ContainsKey(train))
                    {
                        results.Add(train, new Dictionary<string, int>());
                        foreach (var wagon in results[otherTrainName])
                        {
                            results[train].Add(wagon.Key, wagon.Value);
                        }
                        results.Remove(otherTrainName);
                    }
                    else
                    {
                        foreach (var wagon in results[otherTrainName])
                        {
                            results[train].Add(wagon.Key, wagon.Value);
                        }
                        results.Remove(otherTrainName);
                    }
                }

                //Copies the other train’s wagons
                else if (splitter[1] == "=")
                {
                    string train = splitter[0];
                    string otherTrainName = splitter[2];

                    if (!results.ContainsKey(train))
                    {
                        results.Add(train, new Dictionary<string, int>());
                        foreach (var wagon in results[otherTrainName])
                        {
                            results[train].Add(wagon.Key, wagon.Value);
                        }
                    }
                    else
                    {
                        results.Remove(train);
                        results.Add(train, new Dictionary<string, int>());
                        foreach (var wagon in results[otherTrainName])
                        {
                            results[train].Add(wagon.Key, wagon.Value);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var result in results.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine($"Train: {result.Key}");
                foreach (var wagon in result.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
