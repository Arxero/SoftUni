using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _43.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {",", " "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //string[] input = "M3ph-0.5s-0.5t0.0**".Split(new[] {",", " "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string healthPattern = @"[^0-9+\-\*\/\.]";
            string damagePattern = @"((-|\+)?[0-9]+(\.[0-9]+)?)";
            string additionalDamagePattern = @"\*|\/";
            List<string> result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                //health
                MatchCollection health = Regex.Matches(input[i], healthPattern);
                char[] healthChars = new char[health.Count];
                int sumHealth = 0;

                for (int k = 0; k < health.Count; k++)
                {
                    healthChars[k] = char.Parse(health[k].ToString());
                    sumHealth += healthChars[k];
                }

                //damage
                MatchCollection damage = Regex.Matches(input[i], damagePattern);
                double sumDamage = 0;

                for (int k = 0; k < damage.Count; k++)
                {
                    sumDamage += double.Parse(damage[k].Value);
                }

                //additional damage
                MatchCollection additionalDamage = Regex.Matches(input[i], additionalDamagePattern);

                for (int k = 0; k < additionalDamage.Count; k++)
                {
                    char symbol = char.Parse(additionalDamage[k].Value);
                    if (symbol == '*')
                    {
                        sumDamage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        sumDamage /= 2;
                    }
                }

                //collecting the result
                string resultString = $"{input[i]} - {sumHealth} health, {sumDamage:f2} damage";
                result.Add(resultString);
            }
            result.Sort();
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
