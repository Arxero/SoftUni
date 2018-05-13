using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('=', ' ').ToList();
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>(); //displayed in the order of their first appearance.

            while (true)
            {
                if (input[0] == "end")
                {
                    break;
                }

                string IP = input[1];
                string name = input[5];

                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>()); // when our user dict does not contain the name
                }
                if (!users[name].ContainsKey(IP))
                {
                    users[name].Add(IP, 0); // when we already have name added to the users dict, we just adding a IP to the that name
                }
                users[name][IP] += 1;
                input = Console.ReadLine().Split('=', ' ').ToList();
            }
            var orderedUsers = users.OrderBy(x => x.Key).ToList(); // sorted alphabetically

            foreach (var item in orderedUsers)
            {
                Console.WriteLine($"{item.Key}:");
                int counter = 1;
                foreach (var IPAndTime in item.Value)
                {
                    if (item.Value.Count == counter)
                    {
                        Console.WriteLine($"{IPAndTime.Key} => {IPAndTime.Value}.");
                        break;
                    }
                        Console.Write($"{IPAndTime.Key} => {IPAndTime.Value}, ");
                        counter++;
                }

            }
        }
    }
}
