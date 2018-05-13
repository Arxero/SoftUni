using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _35.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<(.)(.)>";

            MatchCollection mines = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();
            sb.Append(input);

            foreach (Match mine in mines)
            {
                char firstCharacter = mine.Groups[1].Value[0];
                char secondCharacter = mine.Groups[2].Value[0];
                int power = Math.Abs(firstCharacter - secondCharacter);

                int start = mine.Index - power;
                int end = (mine.Index + 4) + power;

                if (start < 0)
                {
                    start = 0;
                }
                if (end > input.Length)
                {
                    end = input.Length;
                }
                
                string beforeMine = sb.ToString().Substring(0, start);
                string atTheMine = new string('_', end - start);
                string afterMine = sb.ToString().Substring(end);
                sb.Clear();
                sb.Append(beforeMine + atTheMine + afterMine);
            }
            Console.WriteLine(sb);
        }
    }
}
