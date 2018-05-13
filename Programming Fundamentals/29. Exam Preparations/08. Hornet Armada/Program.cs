using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            var legion_soldier_count = new Dictionary<string, Dictionary<string, long>>();
            var acitvity = new Dictionary<string, long>();

            for (long i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { "=", "-", ">", ":", " " }, StringSplitOptions
                    .RemoveEmptyEntries).ToArray();

                var lastActivity = long.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                var soldierCount = long.Parse(input[3]);

                //we are filling up second dictionary
                if (!acitvity.ContainsKey(legionName))
                {
                    acitvity.Add(legionName, lastActivity);
                }
                else
                {
                    if (lastActivity > acitvity[legionName]) // when the new acitvity is less we ignore it
                    {
                        acitvity[legionName] = lastActivity;
                    }
                }

                //we are filling up first dictionary
                if (!legion_soldier_count.ContainsKey(legionName))
                {
                    legion_soldier_count.Add(legionName, new Dictionary<string, long>());
                    legion_soldier_count[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    if (!legion_soldier_count[legionName].ContainsKey(soldierType))
                    {
                        legion_soldier_count[legionName].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        legion_soldier_count[legionName][soldierType] += soldierCount;
                    }
                }
            }
            //prlonging the result
            var prlong = Console.ReadLine().Split('\\');

            if (prlong.Length > 1)
            {
                long activity = long.Parse(prlong[0]);
                string soldier = prlong[1];

                foreach (var item in legion_soldier_count
                    .Where(item => item.Value.ContainsKey(soldier))
                    .Where(item => acitvity[item.Key] < activity)
                    .OrderByDescending(item => item.Value[soldier]))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value[soldier]}");
                }
            }
            else
            {
                string soldier = prlong[0];

                foreach (var item in acitvity
                    .Where(item => legion_soldier_count[item.Key].ContainsKey(soldier))
                    .OrderByDescending(item => item.Value))
                {
                    Console.WriteLine($"{acitvity[item.Key]} : {item.Key}");
                }
            }

        }
    }
}
