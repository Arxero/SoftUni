using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();
            bool lamp = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < input.Length; i+=2)
                {
                    string material = input[i + 1].ToLower();
                    int quantity = int.Parse(input[i]);

                    //we fill the key material
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!materials.ContainsKey(material))
                        {
                            materials.Add(material, quantity);
                        }
                        else
                        {
                            materials[material] += quantity;
                        }

                        //here we check the quantity if it is over 250
                        foreach (var materiall in materials)
                        {
                            if (materiall.Value >= 250)
                            {
                                lamp = true;
                                materials[materiall.Key] -= 250;

                                switch (materiall.Key)
                                {
                                    case "shards":
                                        Console.WriteLine("Shadowmourne obtained!");
                                        break;
                                    case "fragments":
                                        Console.WriteLine("Valanyr obtained!");
                                        break;
                                    case "motes":
                                        Console.WriteLine("Dragonwrath obtained!");
                                        break;
                                }
                                break;
                            }
                        }
                    }
                    //we fill all other junk
                    else
                    {
                        if (!junks.ContainsKey(material))
                        {
                            junks.Add(material, quantity);
                        }
                        else
                        {
                            junks[material] += quantity;
                        }
                    }
                    //breaking out of loops
                    if (lamp)
                    {
                        break;
                    }
                }
                if (lamp)
                {
                    break;
                }
            }
            //adding the empty key materials if they do are not in the input
            if (!materials.ContainsKey("shards"))
            {
                materials.Add("shards", 0);
            }
            if (!materials.ContainsKey("fragments"))
            {
                materials.Add("fragments", 0);
            }
            if (!materials.ContainsKey("motes"))
            {
                materials.Add("motes", 0);
            }

            foreach (var keyMaterial in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{keyMaterial.Key}: {keyMaterial.Value}");
            }
            foreach (var junk in junks.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
