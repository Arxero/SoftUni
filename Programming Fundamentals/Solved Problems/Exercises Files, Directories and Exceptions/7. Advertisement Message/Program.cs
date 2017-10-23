using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
{
                "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can't live without this product."
};
            string[] events = new string[]
            {   "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            int n = int.Parse(File.ReadAllText("input.txt"));
            for (int i = 0; i < n; i++)
            {
                string formatformat = string.Format("{0} {1} {2} - {3}",
                    phrases[rnd.Next(phrases.Length)],
                    events[rnd.Next(events.Length)],
                    authors[rnd.Next(authors.Length)],
                    cities[rnd.Next(cities.Length)] + Environment.NewLine);
                File.AppendAllText("output.txt", formatformat);
            }
        }
    }
}
