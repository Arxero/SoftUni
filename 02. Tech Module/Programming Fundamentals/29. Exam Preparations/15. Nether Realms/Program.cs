using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(d => d).ToArray();

            Regex healthPattern = new Regex(@"[^0-9+*/.-]");
            Regex damagePattern = new Regex(@"\+?-?[0-9]+\.?[0-9]*");

            foreach (var name in input)
            {
                decimal health = 0;
                decimal damage = 0;

                //getting the damage
                MatchCollection collectionDammage = damagePattern.Matches(name);
                foreach (var c in collectionDammage)
                    {
                        damage += decimal.Parse(c.ToString());
                    }

                //chekking if there is * or /
                foreach (var c in name.Where(c => c == '*' || c == '/'))
                {
                    if (c == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                //geeting the health
                MatchCollection collectionHealth = healthPattern.Matches(name);
                foreach (Match match in collectionHealth)
                {
                    foreach (var c in match.ToString())
                    {
                        health += c;
                    }
                }
                Console.WriteLine($"{name} - {health} health, {damage:f2} damage");
            }
        }
    }
}
