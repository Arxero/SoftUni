using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50.Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();
            string priceType = Console.ReadLine();

            decimal entryPointIndexdecimalheList = input[entryPoint];

            var left = Enumerable.Empty<decimal>();
            var right = Enumerable.Empty<decimal>();

            switch (itemType)
            {
                case "cheap":
                    left = input.Take(entryPoint).Where(x => x < entryPointIndexdecimalheList);
                    right = input.Skip(entryPoint + 1).Where(x => x < entryPointIndexdecimalheList);
                    break;
                case "expensive":
                    left = input.Take(entryPoint).Where(x => x >= entryPointIndexdecimalheList);
                    right = input.Skip(entryPoint + 1).Where(x => x >= entryPointIndexdecimalheList);
                    break;
            }
            switch (priceType)
            {
                case "positive":
                    //getting all above 0
                    left = left.Where(x => x > 0);
                    right = right.Where(x => x > 0);
                    break;
                case "negative":
                    //getting all bellow 0
                    left = left.Where(x => x < 0);
                    right = right.Where(x => x < 0);
                    break;
            }
            //getting any + sum
            decimal leftSum = left.Sum();
            decimal rightSum = right.Sum();

            //prdecimal
            if (leftSum > rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else if (leftSum < rightSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
            else
            {
                Console.WriteLine($"Left - {leftSum}");
            }
        }
    }
}
