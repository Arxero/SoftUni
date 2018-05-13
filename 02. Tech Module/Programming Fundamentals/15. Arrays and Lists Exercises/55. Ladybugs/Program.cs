using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            List<long> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            int[] field = new int[fieldSize];

            //placing the bugs on the field
            for (int i = 0; i < input.Count; i++)
            {
                field[i] = 1;
            }

            while (command[0] != "end")
            {
                int ladybugStart = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                //is the given index in the boundty of the array?
                if (ladybugStart < 0 || ladybugStart >= fieldSize)
                {
                    //nothing hapens now
                }
                else
                {
                    if (direction == "right")
                    {
                        //is the bug on the field?
                        if (ladybugStart + flyLength < 0 || ladybugStart + flyLength >= fieldSize)
                        {
                            //we make it fly away
                            input[ladybugStart] = 0;
                        }
                        else
                        {
                            long flyDistance = ladybugStart + flyLength;
                            input[ladybugStart] = 0;

                            while (ladybugStart < fieldSize && ladybugStart >= 0 && flyDistance < fieldSize && flyDistance >= 0)
                            {
                                if (field[flyDistance] == 0)
                                {
                                    field[flyDistance] = 1;
                                    break;
                                }
                                else
                                {
                                    flyDistance += flyDistance;
                                }
                            }
                        }
                    }
                }


                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
