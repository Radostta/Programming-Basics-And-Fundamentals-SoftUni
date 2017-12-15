using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string.Concat(); can concat the elements of an Ienumerables
            ////\t for a tab in the string

            ////SEARCHING
            //string email = "pesho@gosho.org";
            //Console.WriteLine(email.IndexOf("@")); //returns -1 if no such is found
            //var email2 = "pesho@gosho.org@softuni";
            //Console.WriteLine(email.IndexOf("@", 6)); //searches after the 6th, otherwise will give only the first at 5ht position
            //int lastIndex = email.LastIndexOf("org"); //we know after the last one is sth we need to get

            ////PATTERN - searching, counting substrings
            //var text = "ababa caba".ToLower();
            //var pattern = "aba".ToLower();
            //var count = 0;
            //var index = -1;
            //while (true)
            //{
            //    index = text.IndexOf(pattern, index+1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);

            ////SUBSTRING
            //var fileName = @"fafasyarg\sgvdsgagad\gagsgG:\SGgjG\image.jpg";
            //var lastSlash = fileName.LastIndexOf("\\");
            //var imageName = fileName.Substring(lastSlash + 1); //or it can be (lastSlash, 3) - second is number of symbols to take
            //Console.WriteLine(imageName);

            //SPLIT by separators
            //done it already

            ////str.REPLACE

            //string cocktail = "Vodka + Martini";
            //cocktail = cocktail.Replace("+", "and");
            //Console.WriteLine(cocktail);

            ////REMOVE
            //string price = "$ 1234567";
            //string lowPrice = price.Remove(2, 3); //returns $ 4567

            ////TRIM
            //var text1 = "Pesho | Gosho";
            //var text2 = "12    | \t15\r\n";
            //var values = text2.Split('|');

            //Console.WriteLine(values[0].Trim());
            //Console.WriteLine(values[1].Trim());

            ////STRINGBUILDER
            //var str = new StringBuilder();
            //for (int i = 0; i < 100000; i++)
            //{
            //    str.Append("Pesho ");
            //}

            //Console.WriteLine(str.ToString().Length);

            ////str.Remove(5, 6);
            ////str.Insert(5, "Peter");
            ////str.Append("Hello! ");
            ////str[2] = 't'; //StringBuilder is a changable string

            //var timer = new Stopwatch();
            //timer.Start();
            //string result = "";

            //for (int i = 0; i < 20000; i++)
            //{
            //    result += Convert.ToString(i, 2); //we add in the string the number i in dvuichna numerical system
            //}
            //Console.WriteLine(result.Length);
            //Console.WriteLine(timer.Elapsed);

            ////OPTIMIZED:

            //var timer = new Stopwatch();
            //timer.Start();
            //StringBuilder result = new StringBuilder();

            //for (int i = 0; i < 20000; i++)
            //{
            //    result.Append(Convert.ToString(i, 2)); //we add in the string the number i in dvuichna numerical system
            //}
            //Console.WriteLine(result.Length);
            //Console.WriteLine(timer.Elapsed);

            //COMBINING OBJECTS AND DICTIONARIES:
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            while (true)
            {
                string name = Console.ReadLine();
                if (!students.ContainsKey(name))
                {
                    students[name] = new Student() { Name = name, Email = name + "@kfd.com" };
                }
                else
                {
                    Console.WriteLine("The name already exists. Enter a new name.");
                }
            }

            //The HashSet does not allow adding the same name, in the List you can have same names;
            //In reality the key would be an unique id
        }

        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
} 