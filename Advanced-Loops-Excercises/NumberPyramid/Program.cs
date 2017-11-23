using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //WITH while and break;
            int n = int.Parse(Console.ReadLine());
            int currentRow = 1;
            int currentNum = 1;

            while (currentNum <= n)
            {
                for (int i = 0; i < currentRow; i++)
                {
                    //if (currentNum > 1) Console.Write(" ");
                    Console.Write(currentNum + " ");
                    currentNum++;
                    if (currentNum > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                currentRow++;
            }

            ////WITH return;
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;

            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        if (col > 1) Console.Write(" ");
            //        Console.Write(num);
            //        num++;

            //        if (num > n)
            //        {
            //            Console.WriteLine();
            //            return;
            //        }
            //    }
            //    Console.WriteLine();                
            //}


            //WITH break;
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;

            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        if (col > 1) Console.Write(" ");
            //        Console.Write(num);
            //        num++;

            //        if (num > n)
            //        {
            //            break;
            //        }
            //    }

            //    Console.WriteLine();
            //    if (num > n)
            //    {
            //        break;
            //    }
            //}


        }
    }
}
