
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= n; col++)
                {
                    Console.Write(col + " ");
                }
                for (int col = n - 1; col > n - row; col--)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }                                                                                            
                        
            //int n = int.Parse(Console.ReadLine());
            ////int num = 1;

            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        int num = row + col + 1;
            //        if (num > n)
            //        {
            //            num = -num + 2 * n;
            //            //num = 2 * n - num;
            //        }
            //        Console.Write(num + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
