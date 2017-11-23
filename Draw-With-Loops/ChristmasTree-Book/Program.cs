using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
       
            for (int row = 0; row < n + 1; row++)
            {
                int spacesCount = n - row;
                int starsCount = row;
                string spaces = new string(' ', spacesCount);
                string stars = new string('*', starsCount);

                Console.WriteLine(spaces + stars + " | " + stars + spaces);
            }

          
            
            
            //for (int row = 0; row < n + 1; row++)
            //{
            //    for (int spaces = 0; spaces < n - row; spaces++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int stars = 0; stars < row; stars++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write(" | ");
            //    for (int stars = 0; stars < row; stars++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int spaces = 0; spaces < n - row; spaces++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
