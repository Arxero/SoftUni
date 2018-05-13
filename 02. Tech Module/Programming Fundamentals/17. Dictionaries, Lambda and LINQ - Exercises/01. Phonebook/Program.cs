using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                var command = input.Split(' ').ToList();
                if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                }
                else
                {
                    string key = command[1];
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{key} -> {phonebook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
