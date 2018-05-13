using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void ReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void ReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void ReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void PrintReceipt()
        {
            ReceiptHeader();
            ReceiptBody();
            ReceiptFooter();
        }
    }
}
