using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] commands = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var summedWords = new List<string>();
            StringBuilder sb = new StringBuilder();
            var words = "";

            while (commands[0] != "3:1")
            {
                string commandOne = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                

                if (commandOne == "merge")
                {
                    
                    
                    var words2 = "";
                    for (int i = 0; i < endIndex; i++)
                    {

                        //sb.AppendLine(input[startIndex + i].ToString());
                        words = input[startIndex + i] + input[i + 1];
                        //words = input[startIndex + i];
                        //summedWords.Add(words);
                        //words2 = summedWords[i] + summedWords[i + 1];
                        
                    }
                    

                }
                commands[0] = Console.ReadLine();

            }
            Console.WriteLine(words);
        }
    }
}
