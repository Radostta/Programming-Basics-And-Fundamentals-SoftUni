﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)"); //, RegexOptions.Multiline);

            var text = Console.ReadLine();

            var emails = regex.Matches(text);

            //var emails = Regex.Matches(text, regex);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
