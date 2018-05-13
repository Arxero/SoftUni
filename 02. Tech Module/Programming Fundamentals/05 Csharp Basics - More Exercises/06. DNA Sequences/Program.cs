using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int newLineCounter = 0;
            int nucleotideValue = 0;
            int nucleotideValueSum = 0;
            int nucleotideValueSumRestarter = 0;

            int nucleotideValueA = 0;
            int nucleotideValueC = 0;
            int nucleotideValueG = 0;
            int nucleotideValueT = 0;

            for (char a = 'A'; a <= 'T'; a++)
            {
                for (char b = 'A'; b <= 'T'; b++)
                {
                    for (char c = 'A'; c <= 'T'; c++)
                    {
                        if ((a == 'A' || a == 'C' || a == 'G' || a == 'T') && (b == 'A' || b == 'C' || b == 'G' || b == 'T') && (c == 'A' || c == 'C' || c == 'G' || c == 'T'))
                        {
                            switch (a)
                            {
                                case 'A':
                                    nucleotideValue = 1;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'C':
                                    nucleotideValue = 2;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'G':
                                    nucleotideValue = 3;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'T':
                                    nucleotideValue = 4;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                            }

                            switch (b)
                            {
                                case 'A':
                                    nucleotideValue = 1;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'C':
                                    nucleotideValue = 2;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'G':
                                    nucleotideValue = 3;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'T':
                                    nucleotideValue = 4;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                            }

                            switch (c)
                            {
                                case 'A':
                                    nucleotideValue = 1;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'C':
                                    nucleotideValue = 2;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'G':
                                    nucleotideValue = 3;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                                case 'T':
                                    nucleotideValue = 4;
                                    //nucleotideValueA = 1;
                                    //nucleotideValueC = 2;
                                    //nucleotideValueG = 3;
                                    //nucleotideValueT = 4;
                                    break;
                            }
                            nucleotideValueSum += nucleotideValue;
                            nucleotideValueSumRestarter++;
                            //nucleotideValueSum = nucleotideValueA + nucleotideValueC + nucleotideValueG + nucleotideValueT;
                            //Console.WriteLine(nucleotideValueSum);
                            if (nucleotideValueSum >= n)
                            {
                                Console.Write($"O");
                            }
                            else
                            {
                                Console.Write($"X");
                            }
                            Console.Write($"{a}{b}{c}");
                            newLineCounter++;

                            if (nucleotideValueSum >= n)
                            {
                                Console.Write($"O ");
                            }
                            else
                            {
                                Console.Write($"X ");
                            }




                            if (nucleotideValueSumRestarter >= 3)
                            {
                                nucleotideValueSumRestarter = 0;
                                nucleotideValueSum = 0;
                            }

                        }
                        if (newLineCounter >= 4)
                        {
                            Console.WriteLine();
                            newLineCounter -= 4;
                        }
                    }
                }
            }
        }
    }
}
