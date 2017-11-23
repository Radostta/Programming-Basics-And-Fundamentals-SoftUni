using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (4 * n) + 1;
            int height = (2 * n) + 1;
            Console.WriteLine(new string('#', width)); //First line

            int sideDots = 1;
            int leftHashtags = (2 * n) - 1;
            int spaces = 1;

            for (int row = 1; row <= n; row++)
            {
                if (row == n / 2 + 1)
                {
                    int newSpaces = (spaces - 3) / 2;
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', sideDots), new string('#', leftHashtags), new string(' ', newSpaces));                    
                }
                else
                {                    
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', sideDots), new string('#', leftHashtags), new string(' ', spaces));
                }
                sideDots++;
                leftHashtags -= 2;
                spaces += 2;
            }

            spaces -= 2;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', sideDots), new string('#', spaces));
                sideDots++;
                spaces -= 2;
            }



        }
    }
}
