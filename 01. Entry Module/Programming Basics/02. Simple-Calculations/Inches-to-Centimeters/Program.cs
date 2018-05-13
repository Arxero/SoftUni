using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches= ");
            var inches = double.Parse(Console.ReadLine());
            //Console.WriteLine("Answer: {0}", inches*2.54 +"cm");
            var centimeteres = inches*2.54;
            Console.Write("centimeteres = ");
            Console.WriteLine(centimeteres);
            //Console.Write("cm");
            //Console.WriteLine();
            
        }
    }
}
