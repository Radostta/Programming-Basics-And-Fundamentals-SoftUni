using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] file1 = File.ReadAllLines("FileOne.txt").Select(int.Parse).ToArray();
            int[] file2 = File.ReadAllLines("FileTwo.txt").Select(int.Parse).ToArray();

            List<int> file3 = new List<int>();

            foreach (var number in file1)
            {
                file3.Add(number);
            }

            foreach (var number in file2)
            {
                file3.Add(number);
            }
           
            string result2 = "";

            foreach (var item in file3.OrderBy(x => x))
            {
                result2 += item + Environment.NewLine;
            }
            
            File.WriteAllText("result3.txt", result2);

        }
    }
}
