using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsSum = 0;

            for (int i = 0; i < text.Length; i++)
            {
             switch (text[i])
                {
                    case 'a':
                        vowelsSum += 1;
                        break;
                    case 'e':
                        vowelsSum += 2;
                        break;
                    case 'i':
                        vowelsSum += 3;
                        break;
                    case 'o':
                        vowelsSum += 4;
                        break;
                    case 'u':
                        vowelsSum += 5;   
                        break;
                }
            }

            Console.WriteLine(vowelsSum);


            //string text = Console.ReadLine();
            //int vowelsSum = 0;

            //for (int i = 0; i < text.Length; i++)
            //{

            //    if (text[i] == 'a')
            //    {
            //        vowelsSum += 1;
            //    }
            //    else if (text[i] == 'e')
            //    {
            //        vowelsSum += 2;
            //    }
            //    else if (text[i] == 'i')
            //    {
            //        vowelsSum += 3;
            //    }
            //    else if (text[i] == 'o')
            //    {
            //        vowelsSum += 4;
            //    }
            //    else if (text[i] == 'u')
            //    {
            //        vowelsSum += 5;
            //    }
            //}

            //Console.WriteLine(vowelsSum);



            //string text = Console.ReadLine();
            //int vowelsSum = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    char current = text[i];

            //    if (current == 'a')
            //    {
            //        vowelsSum += 1;
            //    }
            //    else if (current == 'e')
            //    {
            //        vowelsSum += 2;
            //    }
            //    else if (current == 'i')
            //    {
            //        vowelsSum += 3;
            //    }
            //    else if (current == 'o')
            //    {
            //        vowelsSum += 4;
            //    }
            //    else if (current == 'u')
            //    {
            //        vowelsSum += 5;
            //    }
            //}

            //Console.WriteLine(vowelsSum);
        }
    }
}
