using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int elders = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string trasnport = Console.ReadLine().ToLower();

            double priceElders = 0;
            double priceStudents = 0;

            switch (trasnport)
            {
                case "airplane":
                    priceElders = 70;
                    priceStudents = 50;
                    break;
                case "boat":
                    priceElders = 42.99;
                    priceStudents = 39.99;
                    break;
                case "bus":
                    priceElders = 32.50;
                    priceStudents = 28.50;
                    break;
                case "train":
                    priceElders = 24.99;
                    priceStudents = 14.99;
                    int group = elders + students;
                    if (group >= 50)
                    {
                        priceElders -= priceElders * 0.5;
                        priceStudents -= priceStudents * 0.5;
                    }
                    break;
            }
            double transportPrice = ((elders * priceElders) + (students * priceStudents))*2;
            double hotelPrice = nights * 82.99;
            double commision = (transportPrice + hotelPrice) * 0.10;
            double total = transportPrice + hotelPrice + commision;
            Console.WriteLine($"{total:f2}");
        }
    }
}
