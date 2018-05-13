using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            string input = Console.ReadLine();

            var winners = new Dictionary<string, List<string>>();
            //_______________________singer___songs___award______

            while (input != "dawn")
            {
                string[] inputSplited = input.Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
                string singer = inputSplited[0];
                string song = inputSplited[1];
                string award = inputSplited[2];

                if (!participants.Any(s => s == singer) || !songs.Any(s => s == song))
                {
                    goto Bellow;
                }

                if (!winners.ContainsKey(singer))
                {
                    winners.Add(singer, new List<string>());
                }
                winners[singer].Add(award);

                Bellow:
                input = Console.ReadLine();

            }
            if (winners.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            foreach (KeyValuePair<string, List<string>> pair in winners
                .OrderByDescending(a => a.Value.Distinct().ToList().Count)
                .ThenBy(n => n.Key))
            {
                var awards = pair.Value.Distinct().ToList();
                Console.WriteLine($"{pair.Key}: {awards.Count} awards");
                foreach (var award in awards.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
