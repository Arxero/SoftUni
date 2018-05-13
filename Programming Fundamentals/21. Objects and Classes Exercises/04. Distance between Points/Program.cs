using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    

    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }


        static void Main(string[] args)
        {
            
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point p1 = new Point { X = input[0], Y = input[1]};
            
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point p2 = new Point { X = input2[0], Y = input2[1] };

            Console.WriteLine($"{CalcDistance(p1, p2):f3}");

        }

        static double CalcDistance(Point a, Point b)
        {
            int deltaX = a.X - b.X;
            int deltaY = a.Y - b.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        
    }
}
