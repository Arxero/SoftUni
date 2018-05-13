using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sumofVowels = 0;
            for (int currentSymbol = 0; currentSymbol < text.Length; currentSymbol++)
            {

                char symbol = text[currentSymbol];
                int vowelPoints = 0;
                if (symbol == 'a')
                {
                    vowelPoints = 1;
                }
                else if (symbol == 'e')
                {
                    vowelPoints = 2;
                }
                else if (symbol == 'i')
                {
                    vowelPoints = 3;
                }
                else if (symbol == 'o')
                {
                    vowelPoints= 4;
                }
                else if (symbol == 'u')
                {
                    vowelPoints = 5;
                }
                sumofVowels += vowelPoints;
                
            }
            Console.WriteLine(sumofVowels);
        }
    }
}
