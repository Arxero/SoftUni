using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            int[] indexesToPlantBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commandInput = Console.ReadLine().Split();

            int[] field = PlantBugsOnField(sizeField, indexesToPlantBugs);

            while (commandInput[0] !="end")
            {
                int bugIndex = int.Parse(commandInput[0]);
                string flightDirection = commandInput[1];
                int flightLength = int.Parse(commandInput[2]);

                flightDirection = flightDirectionCorrection(flightDirection, flightLength);

                if (bugIndex >= 0 && bugIndex < sizeField)
                {
                    if (field[bugIndex] == 1)
                    {
                        field[bugIndex] = 0;

                        if (flightDirection == "left")
                        {
                            field = NewFieldLeft(field, bugIndex, flightLength);
                        }

                        if (flightDirection == "right")
                        {
                            field = NewFieldRight(field, bugIndex, flightLength);
                        }
                    }
                }
                commandInput = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", field));
        }

        private static int[] NewFieldRight(int[] field, int bugIndex, int flightLength)
        {
            flightLength = Math.Abs(flightLength);
            for (int i = bugIndex + flightLength; i < field.Length; i = i + flightLength)
            {
                if (field[i] == 0)
                {
                    field[i] = 1;
                    break;
                }
            }

            return field;
        }
        //---------------------------------------------
        private static int[] NewFieldLeft(int[] field, int bugIndex, int flightLength)
        {
            flightLength = Math.Abs(flightLength);
            for (int i = bugIndex - flightLength; i >= 0 ; i = i - flightLength)
            {
                if (field[i] == 0)
                {
                    field[i] = 1;
                    break;
                }
            }
            return field;
        }


        //-----------------------------------
        private static string flightDirectionCorrection(string flightDirection, int flightLength)
        {
            string correctedDirection = flightDirection;
            if (flightLength < 0)
            {
                switch (flightDirection)
                {
                    case "left": correctedDirection = "right";break; 
                    case "right": correctedDirection = "left";break;
                }
            }
            return correctedDirection;
        }



        //---------------------------------------------------
        private static int[] PlantBugsOnField(int sizeField, int[] indexesToPlantBugs)
        {
            int[] field = new int[sizeField];
            for (int i = 0; i < indexesToPlantBugs.Length; i++)
            {
                if (indexesToPlantBugs[i] >= 0 && indexesToPlantBugs[i] < sizeField)
                {
                    field[indexesToPlantBugs[i]] = 1;
                }
            }
            return field;
        }
    }
}
