using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Book_Library_Modification
{
    class Test
    {
        static void Main()
        {
            StreamReader file = new StreamReader("input.txt");
            int n = int.Parse(file.ReadLine());
            Library lib = new Library() { Books = new List<Book>() };
            for (int i = 0; i < n; i++)
            {
                string[] input = file.ReadLine().Split(' ');
                Book book = new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBNnumber = input[4],
                    Price = decimal.Parse(input[5])
                };
                lib.Books.Add(book);
            }
            DateTime date = DateTime.ParseExact(file.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in lib.Books.Where(x => x.ReleaseDate > date).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                string formatformat = string.Format("{0} -> {1}.{2:d2}.{3}", book.Title, book.ReleaseDate.Day, book.ReleaseDate.Month, book.ReleaseDate.Year);
                File.AppendAllText("output.txt", formatformat + Environment.NewLine);
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBNnumber { get; set; }
        public decimal Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}