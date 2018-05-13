using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var track = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            var checkpoints = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            foreach (var name in names)
            {
                decimal fuel = name[0];
                int checkpointReached = 0;

                for (int i = 0; i < track.Count; i++)
                {
                    bool lamp = false;

                    for (int k = 0; k < checkpoints.Count; k++)
                    {
                        if (i == checkpoints[k])
                        {
                            lamp = true;
                            break;
                        }
                    }

                    if (lamp == true)
                    {
                        fuel += track[i];
                    }
                    else
                    {
                        fuel -= track[i];
                        
                    }

                    if (fuel > 0)
                    {
                        checkpointReached++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} - reached {checkpointReached}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{name} - fuel left {fuel:f2}");
                }
            }


        }
    }
}
