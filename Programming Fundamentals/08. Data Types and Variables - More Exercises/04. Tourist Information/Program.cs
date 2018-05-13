using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());

            double value = 0;
            string convertedValue = "";

            switch (imperialUnit)
            {
                case "miles":
                    value = valueToConvert * 1.6;
                    convertedValue = "kilometers";
                    break;
                case "inches":
                    value = valueToConvert * 2.54;
                    convertedValue = "centimeters";
                    break;
                case "feet":
                    value = valueToConvert * 30;
                    convertedValue = "centimeters";
                    break;
                case "yards":
                    value = valueToConvert * 0.91;
                    convertedValue = "meters";
                    break;
                case "gallons":
                    value = valueToConvert * 3.8;
                    convertedValue = "liters";
                    break;
            }
            Console.WriteLine($"{valueToConvert} {imperialUnit} = {value:f2} {convertedValue}");

        }
    }
}
