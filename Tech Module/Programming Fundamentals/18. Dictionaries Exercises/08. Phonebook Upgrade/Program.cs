using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                //we add
                if (input[0] == "A")
                {
                    string name = input[1];
                    string number = input[2];
                    //adding to the phonebook contacts
                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, number);
                    }
                    else
                    {
                        phonebook[name] = number;
                    }
                }

                //we search
                else if (input[0] == "S")
                {
                    string name = input[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                //we print ordered
                else if (input[0] == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
