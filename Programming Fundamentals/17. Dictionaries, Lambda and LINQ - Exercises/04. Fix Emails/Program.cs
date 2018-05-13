using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var emailCollector = new Dictionary<string, string>();

            while (input != "stop")
            {
                string email = Console.ReadLine();
                string emailLastTwo = email.Substring(email.Length - 2);
                if (!emailLastTwo.Equals("uk") && !emailLastTwo.Equals("us"))
                {
                    emailCollector[input] = email;
                }
                input = Console.ReadLine();
            }

            foreach (var item in emailCollector)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
