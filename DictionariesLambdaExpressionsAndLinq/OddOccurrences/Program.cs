using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution with one cycle and without a List:

            var input = Console.ReadLine();
            var words = input.ToLower().Split(' '); //an array

            var wordCount = new Dictionary<string, int>();
            
            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }            

            foreach (var item in wordCount)
            {
                if (item.Value % 2 != 0)
                {                    
                    Console.Write(item.Key + " ");
                }
            }

            Console.WriteLine();

            //----------------------------

            ////Solution with one cycle instead of two:

            //var input = Console.ReadLine();
            //var words = input.ToLower().Split(' '); //an array

            //var wordCount = new Dictionary<string, int>();

            ////Only one cycle for initializing the new words and counting them:
            //foreach (var word in words)
            //{
            //    if (wordCount.ContainsKey(word))
            //    {
            //        wordCount[word]++;
            //    }
            //    else
            //    {
            //        wordCount[word] = 1;
            //    }
            //}                    

            //List<string> result = new List<string>();

            //foreach (var item in wordCount)
            //{
            //    if (item.Value % 2 != 0) 
            //    {
            //        result.Add(item.Key);
            //    }
            //}

            //Console.WriteLine(String.Join(", ", result));

            //---------------------------

            //Fist solution:
            ////STEP 1: reading the input data

            ////var input = "Java C# PHP PHP JAVA C java"; //first we use an example to easily debug, at the end we change it to cr();

            //var input = Console.ReadLine();
            //var words = input.ToLower().Split(' '); //an array

            //var wordCount = new Dictionary<string, int>();

            ////STEP 2: checking for duplicating words - with dictionary - words are going to be Keys, and their occurence will be their Values

            ////initializing the keys:
            //foreach (var word in words)
            //{
            //    wordCount[word] = 0;
            //}

            ////initializing the values:
            //foreach (var word in words)
            //{
            //    wordCount[word]++;
            //}

            ////STEP 3: printing all keys that occur an odd number of times:

            //List<string> result = new List<string>(); //this will be the list with the words we need to print

            //foreach (var item in wordCount) //walking the dictionary
            //{
            //    if (item.Value % 2 != 0) //if the value of that key in the dictionary is odd
            //    {
            //        result.Add(item.Key);
            //    }
            //}

            //Console.WriteLine(String.Join(", ", result));

        }
    }
}
