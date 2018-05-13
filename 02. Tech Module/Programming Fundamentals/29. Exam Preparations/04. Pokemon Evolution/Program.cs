using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Evolutions
{
    public string EvoType   { get; set; }
    public int EvoIndex { get; set; }
}

namespace _04.Pokemon_Evolution
{
    

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dictionary = new Dictionary<string, List<Evolutions>>();

            while (input != "wubbalubbadubdub")
            {
                string[] inputInfo = input.Split( new string[] { " ", "-", ">"},StringSplitOptions.RemoveEmptyEntries).ToArray();

                string pokemonName = inputInfo[0];
                

                if (inputInfo.Length > 1)
                {
                    string evolutionType = inputInfo[1];
                    int evolutionIndex = int.Parse(inputInfo[2]);

                    var newEvolution = new Evolutions();
                    newEvolution.EvoType = evolutionType;
                    newEvolution.EvoIndex = evolutionIndex;

                    if (!dictionary.ContainsKey(pokemonName))
                    {
                        dictionary[pokemonName] = new List<Evolutions>();
                    }
                    dictionary[pokemonName].Add(newEvolution);
                }
                else
                {
                    if (dictionary.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var item in dictionary[pokemonName])
                        {
                            Console.WriteLine($"{item.EvoType} <-> {item.EvoIndex}");
                        }
                    }
                }
                input = Console.ReadLine();
            }


            foreach (var pokemon in dictionary)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var item in pokemon.Value.OrderByDescending(x => x.EvoIndex))
                {
                    Console.WriteLine($"{item.EvoType} <-> {item.EvoIndex}");
                }
            }
        }
    }
}
