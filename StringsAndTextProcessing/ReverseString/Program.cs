using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var reversedStr = new StringBuilder(str.Length);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr.Append(str[i]);
            }

            Console.WriteLine(reversedStr.ToString());
        }
    }
}