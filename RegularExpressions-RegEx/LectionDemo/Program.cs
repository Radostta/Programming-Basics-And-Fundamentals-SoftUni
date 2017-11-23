using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //RegEx describes a search pattern
            //Used to find, extract, replace, split data from text by this pattern

            //SPECIAL CHARACTERS:
            //. means any character - \. for escape

            //Special syntax for matching by patterns:
            //[0-9]+ matches non-empty sequence of digits
            //[A-Z][a-z]* matches a capital + small letters
            //\s+ matches whitespace (non-empty)
            //\S+ matches non-whitespace
            //\w+ matches words

            //* means 0 or more - optional

            // | means or - find this or that

            //? 1 or 0
            //+ at least one
            //* 0 or more

            //In every language there may be different implementations. E.G. The language SQL is the same, but in Oracle or MySQL it's different

            //NOTEPAD++ FIND - SEARCH BY REGULAR EXPRESSION (if we don't have internet)

            //WEBSITES: regexr.com | regex101.com | regextester.com
            //debuggex.com
            //regexone.com
            //w3school.com
            //regex nakov qa challenge

            //(\w+)\:\/\/([a-z0-9._-]+)(.*) - the things in the brackets are the first, the second, and the third group            

            //Regexr.com has a CHEATSHEAT with commands

            //REGEX 101 Code Generator - C#:

            //string pattern = @"(\w+)\:\/\/([a-z0-9._-]+)(.*)/g";
            //string input = @"fdgagafg/gfgaga/gagafdg http:/ FDFDJGdoig123156:/*d;ljfa";

            //foreach (Match m in Regex.Matches(input, pattern))
            //{
            //    Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            //}

            //[A-Z][a-z]+ [A-Z][a-z]+ - \w+@w+\.\w+ MATCHES Ivan Ivanov - ivan@gmail.com
            //The real pattern for email is about 4000 rows
            ////[A-Z][a-z]+ [A-Z][a-z]+ -? \w+@w+\.\w+ - this time we made the dash optional with ?

            //When we make validation we need to get the beginning and end of the line or text!!!!!!! ^start $end
            //^\w{6,12}$ - symbols btw 6 and 12 characters - without special symbols

            //EXAMPLE FOR VALIDATION:
            //Read a username and validate it - is it valid or not:

            //var username = Console.ReadLine();
            //Console.WriteLine(Regex.IsMatch(username, @"^\w{6,12}$"));
            //abc - false
            //peshoooooo - true
            //pesho.goshev - false - . is not allowed
            //kiril2 - true - \w includes digits and slashes
            //kiril_ivanov -true 
            //peter-ivanov - false - no -
            // kiril_ivanov - false - no spaces
            //if we don't specify start and end it will not validate the whole thing - if it find matches inside, it will be true
            //Match, IsMatch, MatchAs, Split - when to use what

            //\b \b is used for start and end of a word
            //@"hgsh" is called a verbatim string - @ helps us quote sth without escaping the C# special characters

            //BACK REFERENCES
            //(<([a-z]+).*?>).*?<\/\2>
            //<a href="http://google.com"> <span>asaadsdasdsad<\span> <\a> - 2 group is a   
            
            //rot13.com -shifting the letters
        }



    }
}
