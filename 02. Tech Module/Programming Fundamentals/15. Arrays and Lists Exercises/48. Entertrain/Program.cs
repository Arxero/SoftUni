using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            List<int> wagons = new List<int>();

            while (input != "All ofboard!")
            {
                int wagon = int.Parse(input);
                wagons.Add(wagon);

                int wagonsSum = wagons.Sum();
                if (wagonsSum > power)
                {
                    int wagonsAverage = (int)wagons.Average();
                    int closest = wagons.OrderBy(x => Math.Abs(wagonsAverage - x)).First();
                    wagons.Remove(closest);
                }

                input = Console.ReadLine();
            }
            wagons.Reverse();
            Console.WriteLine(string.Join(" ", wagons) + " " + power);
        }
    }
}
