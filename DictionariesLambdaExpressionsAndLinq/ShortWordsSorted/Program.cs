using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var words = input.Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var shortWords = words.Where(word => word.Length < 5).Distinct().OrderBy(word => word);

            Console.WriteLine(string.Join(", ", shortWords));         
        }
    }
}
