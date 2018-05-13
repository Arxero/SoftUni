using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>();
            Dictionary<string, int> notKeyMaterial = new Dictionary<string, int>();

            keyMaterial["shards"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["motes"] = 0;
            bool collected = true;
            string win = "";

            while (collected)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                for (int i = 0; i < input.Count; i= i + 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (keyMaterial.ContainsKey(material))
                    {
                        keyMaterial[material] += quantity;
                        if (keyMaterial[material] >= 250)
                        {
                            win = material;
                            keyMaterial[material] -= 250;
                            collected = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!notKeyMaterial.ContainsKey(material))
                        {
                            notKeyMaterial[material] = 0;
                        }
                        notKeyMaterial[material] += quantity;
                    }
                }
            }
            //string theWinner = GetReward(win);
            Console.WriteLine($"{GetReward(win)} obtained!");

            keyMaterial = keyMaterial.OrderBy(x => x.Key).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            notKeyMaterial = notKeyMaterial.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in keyMaterial)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in notKeyMaterial)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
        private static string GetReward(string win)
        {
            switch (win)
            {
                case "motes": return "Dragonwrath"; break;
                case "fragments": return "Valanyr"; break;
                case "shards": return "Shadowmourne"; break;
                default: return "goran"; break;
            }
        }
    }
}
