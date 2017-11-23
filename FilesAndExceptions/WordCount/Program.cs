using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"..\..\output");

            string[] allWords = File.ReadAllText("text.txt").ToLower()
                .Split(new char[] { ' ', '.', ',', '!', '?', '-', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] words = File.ReadAllText("words.txt")
                .Split(' ').Select(w => w.Trim()).ToArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var w in allWords)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }

            //Output for the console:
            //foreach (var wordAndCount in dict.OrderByDescending(w => w.Value))
            //{
            //    if (words.Contains(wordAndCount.Key))
            //    {
            //        Console.WriteLine(wordAndCount.Key + " - " + wordAndCount.Value);
            //    }
            //}
            //Two options for printing: a List and adding the list to a file, or printing line by line

            File.WriteAllText("results.txt", ""); //creating the file empty. If it already exists, it will override

            foreach (var wordAndCount in dict.OrderByDescending(w => w.Value))
            {
                if (words.Contains(wordAndCount.Key))
                {
                    File.AppendAllText(@"..\..\output\results\results1.txt", 
                        wordAndCount.Key + " - " + wordAndCount.Value + Environment.NewLine);
                }
            }

            //results\results.txt is called a relative path, the normal way to use files, instead of giving the whole path C\:...
            //creating in the upper directory is by ..\results
            //the file should be either in the current directory, or in a relative directory

            //changing the name of output directory:
            //Directory.Move(@"..\..\nakov", @"..\..\output");
            

        }
    }
}
