using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {           
            var input = Console.ReadLine();
            string[] words = input.Split(' ');
            
            Random random = new Random(); 

            for (int i = 0; i < words.Length; i++)
            {
                int swapIndexFirst = random.Next(0, words.Length);
                int swapIndexSecond = random.Next(0, words.Length);

                string oldFirst = words[swapIndexFirst];
                words[swapIndexFirst] = words[swapIndexSecond];
                words[swapIndexSecond] = oldFirst;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));

            //Print with for cycle:
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //INFO
            //Random is another C# class: random rnd = new Random();
            //takes two arguments: from two -> in a cycle: cw(rnd.Next(1, 1000)); -> this method excludes 1000 -> [1; 999] / [1; 1000);
            //random.Next returns the next any given number in the interval

            //Random random = new Random(); //creating an object Random (It's important not to stay in the random cycle)
            //Random is a non-static class so we need to create a new instance of it with new
            //When the class is static, we can have only one of it - as is the class Console
        }
    }
}
