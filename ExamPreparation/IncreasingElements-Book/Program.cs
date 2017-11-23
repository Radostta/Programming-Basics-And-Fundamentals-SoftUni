using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentLongest = 0;
            int maxLongest = 0;
            int lastNum = 0;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine()); 
                
                if (num > lastNum) currentLongest++;                                    
                else if (num <= lastNum) currentLongest = 1;

                if (currentLongest > maxLongest) maxLongest = currentLongest;
                lastNum = num;
            }
            Console.WriteLine(maxLongest);
        }
    }
}
