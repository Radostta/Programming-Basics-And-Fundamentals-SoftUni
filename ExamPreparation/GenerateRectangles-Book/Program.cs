using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());           
            int area = 0;
            int count = 0;

            for (int left = -n; left <= n; left++) //left or x1 => -n <= left < right <= n;
            {
                for (int top = -n; top <= n; top++) //top or y1
                {
                    for (int right = left + 1; right <= n; right++) //right or x2
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++) //bottom or y2
                        {                            
                            area = (right - left) * (bottom - top); // with or without Math.Abs for the sides => still works                                                                                 
                            if (area >= m)
                            {
                                Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                                count++;                                
                            }
                        }
                    }
                }
            }
            if (count == 0) Console.WriteLine("No");
        }
    }
}
