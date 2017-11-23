using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new string[] { ",", ";", ":", ".", "!", "(", ")", "\\", "/", "\"", "'", " ", "", "[", "]" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowercaseWords = new List<string>();
            var uppercaseWords = new List<string>();
            var mixedWords = new List<string>();

            foreach (var word in words)
            {
                if (word.All(char.IsLower))
                {
                    lowercaseWords.Add(word);
                }
                else if (word.All(char.IsUpper))
                {
                    uppercaseWords.Add(word);
                }
                else
                {
                    mixedWords.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowercaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", uppercaseWords)}");

        }
    }
}
