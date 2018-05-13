using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var first = input[0];
            string second = input[1];
            Console.WriteLine(GetSumCharacter(first,second));
            
        }
        static decimal GetSumCharacter(string one, string two)
        {
            decimal sum = 0;

            for (int i = 0; i < Math.Min(one.Length, two.Length); i++)
            {
                long multiplier = one[i] * two[i];
                sum = sum + multiplier;
            }
             if (one.Length != two.Length)
                {
                    if (one.Length > two.Length)
                    {
                        int taking = one.Length - two.Length;
                        string strings = one.Substring(two.Length, taking);
                        int stringSum = strings.Sum(p => Convert.ToInt32(p));
                        sum = sum + stringSum;
                    }
                    else if (one.Length < two.Length)
                    {
                        int taking = two.Length - one.Length;
                        string strings = two.Substring(one.Length, taking);
                        int stringSum = strings.Sum(p => Convert.ToInt32(p));
                        sum = sum + stringSum;
                    }
                }   
            return sum; 
        }
    }
}
