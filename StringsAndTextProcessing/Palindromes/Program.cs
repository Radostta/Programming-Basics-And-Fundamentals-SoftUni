using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().
                Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var isPalindrome = isPalindromeFast(words[i]);
                if (isPalindrome)
                {
                    palindromes.Add(words[i]);
                }
            }

            //palindromes.Remove(palindromes.Length - 2, 2);
            //palindromes.Append(".");
            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", palindromes));            
        }

        static bool isPalindromeFast(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}