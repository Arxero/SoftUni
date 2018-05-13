using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] splitter = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = splitter[0];
                int start = int.Parse(splitter[1]);
                int end = int.Parse(splitter[2]);

                if (start < 0 || start > text.Count) start = 0;
                if (end >= text.Count) end = text.Count - 1;



                if (command == "merge")
                {
                    for (int i = start; i < end; i++)
                    {
                        text[start] += text[i + 1];
                        text[i + 1] = "";
                        //text.Add("");
                    }
                    text = text.Where(x => x != "").ToList();
                }
                else
                {
                    int partsCount = text[start].Length / end;
                    string toBeDevided = text[start];
                    text.RemoveAt(start);


                    for (int i = 0; i < int.Parse(splitter[2]); i++)
                    {
                        string taken = toBeDevided.Substring(0, partsCount);
                        toBeDevided = toBeDevided.Remove(0, partsCount);
                        text.Insert(start + i, taken);
                    }

                    

                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
