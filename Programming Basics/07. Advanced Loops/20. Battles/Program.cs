using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonCount1 = int.Parse(Console.ReadLine()); // 5:35
            int pokemonCount2 = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());

            int count = 0;

            for (int countPokemon = 1; countPokemon <= pokemonCount1; countPokemon++)
            {
                for (int countPokemon2 = 1; countPokemon2 <= pokemonCount2; countPokemon2++)
                {
                    count++;
                    if (count > maxBattles)
                    {
                        break;
                    }
                    Console.Write($"({countPokemon} <-> {countPokemon2}) ");
                }
            }
            Console.WriteLine();
        }
    }
}
