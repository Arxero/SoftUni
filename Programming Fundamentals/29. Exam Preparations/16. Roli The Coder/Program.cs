using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //___________________________ID__eventname
            var events = new Dictionary<int, string>();
            var partsByEvent = new Dictionary<string, List<string>>();
            //______________________________eventname____participants


            while (input != "Time for Code")
            {
                if (input.Contains("#"))
                {
                    string[] spliter = input.Split(new[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    int id = int.Parse(spliter[0]);
                    string eventName = spliter[1];
                    var participant = new List<string>();

                    for (int i = 2; i < spliter.Length; i++)
                    {
                        participant.Add(spliter[i]);
                    }

                    if (!events.ContainsKey(id))
                    {
                        events.Add(id, eventName);
                        partsByEvent.Add(eventName, participant);
                    }
                    else if (events[id] == eventName)
                    {
                        partsByEvent[eventName].AddRange(participant);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var part in partsByEvent.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{part.Key} - {part.Value.Distinct().Count()}");

                foreach (var item in part.Value.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}