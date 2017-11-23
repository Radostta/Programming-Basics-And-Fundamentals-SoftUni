using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] oddLines =
                lines.Where((line, index) => index % 2 == 1).ToArray(); //a lambda function with two parameters - the line and the number of the line(index in the array)

            File.WriteAllLines("output.txt", oddLines);

            //With File.
            //string[] lines = File.ReadAllLines("input.txt");
            //File.Delete("odd-lines.txt");

            //for (int i = 1; i < lines.Length; i++)
            //{
            //    File.AppendAllText("odd-lines.txt", lines[i] + Environment.NewLine);
            //}

            //Without Lambda:
            //string[] lines = File.ReadAllLines("input.txt");

            //var oddLinesAgain = new List<string>();

            //for (int i = 1; i < lines.Length; i += 2)
            //{
            //    oddLinesAgain.Add(lines[i]);
            //}            

            //File.WriteAllLines("outputAgain.txt", oddLinesAgain);
        }
    }
}
