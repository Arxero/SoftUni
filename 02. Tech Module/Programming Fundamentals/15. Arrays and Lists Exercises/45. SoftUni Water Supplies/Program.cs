using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.SoftUni_Water_Supplies // 83/100
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal water = decimal.Parse(Console.ReadLine());
            List<decimal> input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            decimal capacity = decimal.Parse(Console.ReadLine());

            int emptyBottlesCount = 0;
            List<decimal> emptyBottlesIndexes = new List<decimal>();
            decimal howMuchMoreWaterWeNeed = 0;

            //is water even number?
            if (water % 2 == 0)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    //is the current bottle empty?
                    if (input[i] < capacity)
                    {
                        //do we have water?
                        if (water > 0)
                        {
                            decimal waterNeeded = capacity - input[i];
                            //do we have  needed water
                            if (water >= waterNeeded)
                            {
                                water = water - (capacity - input[i]);
                                input[i] += waterNeeded;
                            }
                            else if (water < waterNeeded)
                            {
                                input[i] += water;
                                water = 0;
                            }
                        }
                        else
                        {
                            //how many bottles are not filled?
                            emptyBottlesCount = input.Count(x => x != capacity);
                            var emptyBottlesTaken = input.ToList().Where(x => x != capacity).ToList();
                            for (int k = 0; k < emptyBottlesCount; k++)
                            {
                                int indexOfTheBottle = input.IndexOf(emptyBottlesTaken[k]);
                                emptyBottlesIndexes.Add(indexOfTheBottle);
                                decimal howMuchMoreWaterWeNeedCalculation = capacity - emptyBottlesTaken[k];
                                howMuchMoreWaterWeNeed += howMuchMoreWaterWeNeedCalculation;
                            }
                            break;
                        }
                    }
                }
            }

            //is water odd number
            if (water % 2 != 0)
            {
                for (int i = input.Count - 1; i >= 0; i--)
                {
                    //is the current bottle empty?
                    if (input[i] < capacity)
                    {
                        //do we have water?
                        if (water > 0)
                        {
                            decimal waterNeeded = capacity - input[i];
                            //do we have  needed water
                            if (water >= waterNeeded)
                            {
                                water = water - (capacity - input[i]);
                                input[i] += waterNeeded;
                            }
                            else if (water < waterNeeded)
                            {
                                input[i] += water;
                                water = 0;
                            }
                        }
                        else
                        {
                            //how many bottles are not filled?
                            emptyBottlesCount = input.Count(x => x != capacity);
                            var emptyBottlesTaken = input.ToList().Where(x => x != capacity).ToList();
                            for (int k = 0; k < emptyBottlesCount; k++)
                            {
                                int indexOfTheBottle = input.IndexOf(emptyBottlesTaken[k]);
                                emptyBottlesIndexes.Add(indexOfTheBottle);
                                decimal howMuchMoreWaterWeNeedCalculation = capacity - emptyBottlesTaken[k];
                                howMuchMoreWaterWeNeed += howMuchMoreWaterWeNeedCalculation;
                            }
                            emptyBottlesIndexes.Reverse();
                            break;
                        }
                    }
                }



            }//end of is water odd number

            if (water > 0)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {water}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {emptyBottlesCount}");
                Console.WriteLine($"With indexes: {string.Join(", ", emptyBottlesIndexes)}");
                Console.WriteLine($"We need {howMuchMoreWaterWeNeed} more liters!");
            }

        }
    }
}
