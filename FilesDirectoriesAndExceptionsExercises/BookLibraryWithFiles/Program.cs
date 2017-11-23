using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace BookLibraryWithFiles
{
    class Program
    {
        public class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }

            public DateTime ReleaseDate { get; set; }

            public decimal Price { get; set; }

        }
        public class Library
        {
            public string Name { get; set; }

            public List<Book> Books { get; set; }
        }
        public class AuthorSales
        {
            public string Author { get; set; }

            public decimal Sales { get; set; }

        }
        public class BookLibrary
        {
            public static void Main(string[] args)
            {
                string dNframeworkInputPath = @"..\..\Input.txt";
                string[] lines = File.ReadAllLines(dNframeworkInputPath);

                string result = "";

                int n = int.Parse(lines[0]);

                var books = new List<Book>();
                var library = new Library()
                {
                    Name = "Library",
                    Books = new List<Book>()
                };

                for (int i = 1; i <= n; i++)
                {
                    var input = lines[i].Split().ToList();

                    var book = new Book();
                    book.Title = input[0];
                    book.Author = input[1];
                    book.Publisher = input[2];
                    book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    book.Price = decimal.Parse(input[5]);

                    library.Books.Add(book);
                }
                var authorsSales = new List<AuthorSales>();

                var authors = library.Books.Select(a => a.Author).Distinct().ToArray();

                foreach (var author in authors)
                {
                    var sales = library.Books.Where(a => a.Author == author).Sum(a => a.Price);
                    authorsSales.Add(new AuthorSales()
                    {
                        Author = author,
                        Sales = sales
                    });
                }

                authorsSales = authorsSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Author).ToList();

                foreach (var sale in authorsSales)
                {
                    result += $"{sale.Author} -> {sale.Sales:F2}" + Environment.NewLine;
                }

                string dNframeworkOutputPath = @"..\..\Output.txt";
                File.WriteAllText(dNframeworkOutputPath, result);

            }
        }
    }
}