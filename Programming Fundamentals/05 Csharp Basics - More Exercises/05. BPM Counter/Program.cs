using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int bpmNumber = int.Parse(Console.ReadLine());

            double beats2Calculating = Math.Round(bpmNumber / 4.0, 1);
            Console.Write($"{beats2Calculating} bars - ");
            double seconds = bpmNumber * 60.0 / bpm;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;
            Console.WriteLine($"{minutes}m {Math.Floor(seconds)}s");
        }
    }
}
