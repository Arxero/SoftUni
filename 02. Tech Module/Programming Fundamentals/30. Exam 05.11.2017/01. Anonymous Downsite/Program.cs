using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            List<string> sites = new List<string>();
            decimal loss = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                sites.Add(input[0]);
                loss += decimal.Parse(input[1]) * decimal.Parse(input[2]);
            }
            foreach (var site in sites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {loss:f20}");
            BigInteger securityToken = key;
            for (int i = 0; i < sites.Count - 1; i++)
            {
                securityToken *= key;
            }
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
