using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;

namespace BookLibraryModification_With_Files
{
    public class Books
    {
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            string dNframeworkInputPath = @"..\..\Input.txt";
            string[] lines = File.ReadAllLines(dNframeworkInputPath);

            string result = "";

            int n = int.Parse(lines[0]);

            var books = new List<Books>();

            for (int i = 1; i <= n; i++)
            {
                var input = lines[i].Split().ToList();

                var book = new Books();
                book.Name = input[0];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                books.Add(book);
            }

            var date = DateTime.ParseExact(lines[lines.Length - 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in books.OrderBy(d => d.ReleaseDate).ThenBy(a => a.Name))
            {
                if (book.ReleaseDate > date)
                {
                    result += $"{book.Name} -> {book.ReleaseDate:dd.MM.yyyy}" + Environment.NewLine;
                }
            }

            string dNframeworkOutputPath = @"..\..\Output.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
        }
    }
}