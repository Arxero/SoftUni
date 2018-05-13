using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point p = ReadPoint();
                points.Add(p);
            }

            double minDistance = double.MaxValue;
            Point closest1 = null;
            Point closest2 = null;

            for (int p1Index = 0; p1Index < points.Count; p1Index++)
            {
                for (int p2Index = 0; p2Index < points.Count; p2Index++)
                {
                    if (p1Index != p2Index)
                    {
                       double currentDistance = CalcDistance(points[p1Index], points[p2Index]);
                        if (currentDistance < minDistance)
                        {
                            minDistance = currentDistance;
                            closest1 = points[p1Index];
                            closest2 = points[p2Index];
                        }
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({closest1.X}, {closest1.Y})");
            Console.WriteLine($"({closest2.X}, {closest2.Y})");
        }

        private static Point ReadPoint()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point p1 = new Point { X = input[0], Y = input[1] };
            return p1;
        }

        static double CalcDistance(Point a, Point b)
        {
            int deltaX = a.X - b.X;
            int deltaY = a.Y - b.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        
    }
}
