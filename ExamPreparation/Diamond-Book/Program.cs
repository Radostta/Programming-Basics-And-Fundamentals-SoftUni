using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            int sideSpacesCount = n - 1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', sideSpacesCount) + "*");
                for (int i = 0; i < row-1; i++)
                {
                    Console.Write("-*");
                }
                Console.Write(new string(' ', sideSpacesCount));

                sideSpacesCount--;  
                Console.WriteLine();
            }

            sideSpacesCount = 1;

            for (int row = n - 1; row >= 1; row--)
            {
                Console.Write(new string(' ', sideSpacesCount) + "*");
                for (int i = 1; i < row; i++)
                {
                    Console.Write("-*");
                }
                Console.Write(new string(' ', sideSpacesCount));
                
                sideSpacesCount++;
                Console.WriteLine();
            }
        }
    }
}
