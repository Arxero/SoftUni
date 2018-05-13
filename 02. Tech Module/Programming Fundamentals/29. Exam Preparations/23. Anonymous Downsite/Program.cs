using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _23.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            long websites = long.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());

            var siteLossList = new List<decimal>();
            var websiteNameList = new List<string>();

            for (int i = 0; i < websites; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string siteName = input[0];
                
                    long siteVisits = long.Parse(input[1]);
                    decimal siteCommercialPricePerVisit = decimal.Parse(input[2]);
                    decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                    websiteNameList.Add(siteName);
                    siteLossList.Add(siteLoss);
            }
            foreach (var item in websiteNameList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total Loss: {siteLossList.Sum():f20}");
            //Console.WriteLine($"Security Token: {Math.Pow(securityKey, siteLossList.Count)}");
            BigInteger pow = securityKey;
            for (int i = 1; i < siteLossList.Count; i++)
            {
                pow *= securityKey;
            }
            Console.WriteLine($"Security Token: {pow}");
        }
    }
}
