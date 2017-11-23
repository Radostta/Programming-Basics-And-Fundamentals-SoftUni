using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            int currentRow = 1;

            while (currentNum <= n)
            {
                for (int i = 0; i < currentRow; i++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;
                    if (currentNum > n) break;
                }
                currentRow++;
                Console.WriteLine();
            }
            

            //int n = int.Parse(Console.ReadLine());
            //int num = 1;
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 0; col < row; col++)
            //    {                    
            //       Console.Write(num + " ");
            //       num++;
            //        if (num > n) break; 
            //    }
            //    Console.WriteLine();
            //    if (num > n) break;
            //}
        }
    }
}
