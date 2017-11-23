using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupName
{
    class Program
    {
        static void Main(string[] args)
        {
            char l1 = char.Parse(Console.ReadLine()); //capital
            char l2 = char.Parse(Console.ReadLine());
            char l3 = char.Parse(Console.ReadLine());
            char l4 = char.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());

            int combinations = 0;
            string name = ("l1 + l2 + l3 + l4 + d1");

            for (char s1 = 'A'; s1 <= l1; s1++)
            {
                for (char s2 = 'a'; s2 <= l2; s2++)
                {
                    for (char s3 = 'a'; s3 <= l3; s3++)
                    {
                        for (char s4 = 'a'; s4 <= l4; s4++)
                        {
                            for (int s5 = 0; s5 <= d1; s5++)
                            {
                                string combination = "s1 + s2 + s3 + s4 + d1";
                                combinations++;
                                if (combination == name) return;                                
                            }
                        }
                    }
                }
            }
            Console.WriteLine(combinations - 1);

        }
    }
}
