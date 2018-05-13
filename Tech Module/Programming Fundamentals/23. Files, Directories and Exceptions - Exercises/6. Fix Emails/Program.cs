using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");
            string input = file.ReadLine();
            var emailCollector = new Dictionary<string, string>();

            while (input != "stop")
            {
                string email = file.ReadLine();
                string emailLastTwo = email.Substring(email.Length - 2);
                if (!emailLastTwo.Equals("uk") && !emailLastTwo.Equals("us"))
                {
                    emailCollector[input] = email;
                }
                input = file.ReadLine();
            }

            foreach (var item in emailCollector)
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}" + Environment.NewLine);
            }
        }
    }
}
