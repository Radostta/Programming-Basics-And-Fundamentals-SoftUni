using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining an alphabet array:
            char[] alphabet = new char[26];
            char letter = 'a';

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = letter;
                letter++;
            }

            //reading input as char array:
            string inputString = Console.ReadLine();
            var charArray = inputString.ToCharArray(); //convert the string to an array of chars

            //using .Contains() and Array.IntexOf():
            for (int ch = 0; ch < charArray.Length; ch++)
            {
                if (alphabet.Contains(charArray[ch]))
                {
                    Console.Write(charArray[ch] + " -> ");
                    Console.WriteLine(Array.IndexOf(alphabet, charArray[ch]));
                }
            }

            //--------------
            ////finding char indexes in the alphabet array by comparing the arrays:

            //for (int ch = 0; ch < charArray.Length; ch++)
            //{
            //    for (int l = 0; l < alphabet.Length; l++)
            //    {
            //        if (charArray[ch] == alphabet[l])
            //        {
            //            Console.WriteLine($"{charArray[ch]} -> {l}");
            //        }
            //    }
            //}                       

            //Another task: Counting the letter occurences:

            //var text = Console.ReadLine().ToLower(); //reading input
            //var count = new int[26]; //declaring an array for all alphabet letters

            //foreach (var symbol in text)
            //{
            //    if (char.IsLetter(symbol)) //skipping all other symbols in the text
            //    {
            //        count[symbol - 'a']++;
            //    }
            //}

            //for (int i = 0; i < count.Length; i++) //printing - only if contains letters
            //{
            //    if (count[i] > 0)
            //    {
            //        Console.WriteLine($"{(char)(i + 'a')} -> {count[i]}");
            //    }
            //}

        }
    }
}
