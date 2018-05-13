using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z"))
            {
                word.Remove(word.Length - 1);
                word += "es";
            }
            else if (word.EndsWith("ch") || word.EndsWith("sh"))
            {
                word.Remove(word.Length - 1);
                word.Remove(word.Length - 2);
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);

        }
    }
}
