using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int[]>> results = new Dictionary<string, Dictionary<string, int[]>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] splitter = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = splitter[0];
                string dragon = splitter[1];
                int damage = 45;
                int health = 250;
                int armor = 10;
                if (splitter[2] != "null") damage = int.Parse(splitter[2]);
                if (splitter[3] != "null") health = int.Parse(splitter[3]);
                if (splitter[4] != "null") armor = int.Parse(splitter[4]);

                if (!results.ContainsKey(type))
                {
                    results.Add(type, new Dictionary<string, int[]>());
                    results[type].Add(dragon, new int[3]);
                    results[type][dragon][0] = damage;
                    results[type][dragon][1] = health;
                    results[type][dragon][2] = armor;
                }
                else
                {
                    if (!results[type].ContainsKey(dragon))
                    {
                        results[type][dragon] = new int[3];
                        results[type][dragon][0] = damage;
                        results[type][dragon][1] = health;
                        results[type][dragon][2] = armor;
                    }
                    else
                    {
                        results[type][dragon][0] = damage;
                        results[type][dragon][1] = health;
                        results[type][dragon][2] = armor;
                    }
                }
            }
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key}::({result.Value.Select(x=> x.Value[0]).Average():f2}/{result.Value.Select(x => x.Value[1]).Average():f2}/{result.Value.Select(x => x.Value[2]).Average():f2})");

                foreach (var dragon in result.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }

        }
    }
}
