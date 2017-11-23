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

            //top part
            int mid = -1;
            if (n % 2 == 0) mid = 0;

            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                int side = (n - 2 - mid) / 2;
                Console.Write(new string('-', side));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.Write(new string('-', side));
                Console.WriteLine();
                mid = mid + 2;
            }

                //bottom part

                mid = n - 4;

                for (int i = 1; i < (n + 1) / 2; i++)
                {
                    int side = (n - 2 - mid) / 2;
                    Console.Write(new string('-', side));
                    Console.Write("*");
                    if (mid >= 0)
                    {
                        Console.Write(new string('-', mid));
                        Console.Write("*");
                    }
                    Console.Write(new string('-', side));
                    Console.WriteLine();
                    mid = mid - 2;
                }

                //int stars = 1; //+ ((n + 1) % 2); Beginning with stars count
                //if (n % 2 == 0) stars = 2;
                ////int mid = -1;
                ////if (n % 2 == 0) mid = 0;
                //int mid = stars - 2;

                //for (int i = 1; i <= (n + 1) / 2; i++)
                //{
                //    int side = (n - stars - mid) / 2;
                //    Console.Write('*');
                //    Console.WriteLine();
                //}

            
                ////First row
                //int starCount = 1;
                //if (n % 2 == 0)
                //{
                //    starCount++;
                //}
                //int dashesCount = (n - starCount) / 2;
                //string dashes = new string('-', dashesCount);
                //string stars = new string('*', starCount);
                //Console.WriteLine($"{dashes}{stars}{dashes}");

                ////Second part
                //for (int outerDashes = dashesCount - 1; outerDashes >= 0; outerDashes--)
                //{
                //    string outer = new string('-', outerDashes);
                //    string middle = new string('-', n - outerDashes * 2 - 2);
                //    Console.WriteLine($"{outer}*{middle}*{outer}");
                //}

                ////Third part
                //for (int outerDashes = 1; outerDashes < (n - 1) / 2; outerDashes++)
                //{
                //    string outer = new string('-', outerDashes);
                //    string middle = new string('-', n - outerDashes * 2 - 2);
                //    Console.WriteLine($"{outer}*{middle}*{outer}");
                //}

                ////Last row
                //if (n > 2)
                //{
                //    Console.WriteLine($"{dashes}{stars}{dashes}");
                //}

           
        }
    }
}
