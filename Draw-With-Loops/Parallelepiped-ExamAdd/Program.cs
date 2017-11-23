using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped_ExamAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 1;
            int height = 4 * n + 4;

            int middle = n - 2;
            int dots = width - middle - 2;
            Console.WriteLine("+{0}+{1}", new string('~', middle), new string('.', dots)); //First line
            dots--;
            Console.WriteLine("|\\{0}\\{1}", new string('~', middle), new string('.', dots)); //second line

            //Top part
            int leftDots = 1;
            int rightDots = width - 3 - leftDots - middle;
            for (int row = 0; row < n * 2; row++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', leftDots), new string('~', middle), new string('.', rightDots));
                leftDots++;
                rightDots--;
            }

            //Bottom part
            leftDots = 0;
            rightDots = width - 3 - leftDots - middle;
            for (int row = 0; row < n * 2; row++)
            {
                Console.WriteLine("{0}\\{2}|{1}|", new string('.', leftDots), new string('~', middle), new string('.', rightDots));
                leftDots++;
                rightDots--;
            }

            middle = n - 2;
            dots = width - middle - 3;            
            Console.WriteLine("{1}\\|{0}|", new string('~', middle), new string('.', dots)); //Pre-last line            
            dots++;
            Console.WriteLine("{1}+{0}+", new string('~', middle), new string('.', dots)); //Last line
        }
    }
}
