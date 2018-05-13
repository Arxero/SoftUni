using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string createFile = @"fille.txt";
            string[] names = File.WriteAllText("fille.txt", "hehe");
            //string text = File.ReadAllText("file.txt");
        }
    }
}
