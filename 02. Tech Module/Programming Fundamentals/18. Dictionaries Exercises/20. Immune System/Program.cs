using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            string virus = Console.ReadLine();
            List<string> virusAgain = new List<string>();

            double healthClone = health;

            while (virus != "end")
            {
                int virusStrength = virus.Sum(x => x) / 3;
                int timeDefeat = virusStrength * virus.Length;

                if (virusAgain.Contains(virus))
                {
                    virusAgain.Remove(virus);
                    timeDefeat /= 3;
                }
                virusAgain.Add(virus);

                string timeDefeatStr = timeDefeat.ToString();
                var ts = TimeSpan.FromSeconds(timeDefeat);
                string time = string.Format($"{(int)ts.TotalMinutes}m {ts.Seconds}s.");

                healthClone -= timeDefeat;

                if (health > timeDefeat)
                {
                    Console.WriteLine($"Virus {virus}: {virusStrength} => {timeDefeat} seconds");
                    Console.WriteLine($"{virus} defeated in {time}");
                    Console.WriteLine($"Remaining health: {healthClone}");

                    healthClone += (int)(healthClone * 0.20);
                    if (healthClone > health)
                    {
                        healthClone = health;
                    }

                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }


                virus = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {healthClone}");
        }
    }
}
