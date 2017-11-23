using System;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = 
                Console.ReadLine().
                Split(',', ' ').
                Where(w => w.Length > 0).ToArray();
            var text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                var replacement = word.Length;
                text = text.Replace(word, new string('*', replacement));
            }

            Console.WriteLine(text);
        }
    }
}