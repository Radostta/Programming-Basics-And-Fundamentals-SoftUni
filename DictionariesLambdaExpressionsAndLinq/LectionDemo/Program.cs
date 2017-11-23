using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //.ThenBy() -Sorting dictionaries- first by values, and if they are not equal - by key

            //.Single(x => x == 4)

            //CONCATANATION
            //nums = nums.Concat(otherNums);
            
            //Linq and Lambda

            //var nums = new List<int> { 10, 20, 34, 30, 50, 60 }.Min();
            //Console.WriteLine(nums.Min());
            //Console.WriteLine(nums.Max());
            //Console.WriteLine(nums.Average()); //can return double
            //Console.WriteLine(nums.First());
            //Console.WriteLine(nums.Last());
            //Console.WriteLine(nums.Skip(2).First()); //if list.Count >= 3 than do this
            //Console.WriteLine(nums.SkipWhile(x => x < 0));

            //Console.WriteLine(nums.Where(x => x > 25)); //lambda function, given as a parameter - element of the functional programming = meta programming
            //var result = nums.Where(x => x > 25).Last();
            //var result1 = nums.Where(x => x > 25).Skip(1).First();
            //This does not change the original list, it copies it, it works as a stream - stream API in Java

            //LAMBDA CONDITION AS STATIC BOOL outside of Main:

            //static bool BigThan25(int x);
            //{
            //    return x > 25;
            //}
            //in Main: var result = nums.Where(BigThan25).Last();

            //Console.WriteLine(String.Join(", ", result));

            //Console.WriteLine(nums.Sum());

            //.nums.OrderByDiscending(x => x);
            //...((x, y) => x + 1);
            //.Distinct() - remove duplicates

            //SPLIT returns an array, SELECT returns an Ienumerable from string = poredica ot stringove

            //SELECT - Transforming, mapping

            //Console.WriteLine(nums.Select(number => number * 2); - returns number, multiplied by 2 - foreach number, do this function
            //Console.WriteLine(nums.Select(number => number *= 2);

            //Console.WriteLine(nums.Select(number => double.Parse(number))); //(double.Parse) short version
            //Console.WriteLine(nums.Select(number => "hello" + number + "ehoo"); - returns text between the numbers
            //after => we can place return, for cycle and whatever
            //.Select(str => str.Length) - take a string a returns its length - it can be 2 * str.Length - 1

            //Console.WriteLine(nums.Split());


            //Sorting and taking values:
            //var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var result = numbers.OrderByDescending(x => x).Take(3);


            //-------------------

            ////SortedDictionary example with dates:
            ////by Key date we will keep an event, that happened at that date:

            //var events = new SortedDictionary<DateTime, string>();
            //events[new DateTime(1998, 9, 4)] = "Google's birth date";
            //events[new DateTime(2013, 11, 5)] = "SoftUni's birth date";
            //events[new DateTime(1975, 4, 4)] = "Microsoft's birth date";
            //events[new DateTime(2004, 2, 4)] = "Facebook's birth date";

            //events.Remove(new DateTime(1998, 9, 4));
            //Console.WriteLine(events[new DateTime(2013, 11, 5)]);

            //foreach (var e in events)
            //{
            //    Console.WriteLine($"{e.Key} -> {e.Value}");
            //}

            ////Printing formatted dateTime:

            //foreach (var e in events)
            //{
            //    Console.WriteLine($"{e.Key:dd-MMM-yyyy} -> {e.Value}");
            //}

            //----------------------------------

            //if there is more than one event, we can put them all in one string, or we can make a List of the events as a value


            //NOT TO GET AN EXCEPTION WHEN SEARCHING: (IF ())
            //TRY GET - FOR searching a key and saving it as a value - otherwise with containsKey we need to say cw(phonebook["Pesho"]) - this prints the value;
            //string val;
            //if (phonebook.TryGetValue("Pesho", out val))
            //{
            //    Console.WriteLine(val);
            //}

            //ContainsKey() fast 
            //ContainsValue() searching by value is slow - it is linear, scanning one by one each element

            //SORTEDDICTIONARY: Uses hash tables + List:
            //var sortedDict = new SortedDcitionary<strng, int>();
            //ROLE: we can QUICKLY FIND, add and remove by KEY

            //OPERATIONS (API - nabor ot operacii): ADD, REMOVE, FIND, CONTAINS
            //phonebook.ContainsKey("Varna"); - true or false

            //Dictionary is a system.generics class like the List and has Count as length
            //At position [0] we have [key, value]

            //var phonebook = new Dictionary<string, string>();
            //phonebook["John Smith"] = "+1-555-234-987";
            //    phonebook["John Smith"] = "+5-333-234-987"; //replace
            //    phonebook.Remove("John Smith"); //remove - unlike with the lists, the values do not move to the left, so adding and removing is natural and faster
            //    //ADD AND REMOVE - it does not depend on the size of the dictionary - the secret is in some hash functions that transform the key to an array
            //    phonebook["Me"] = "t644664666136";
            //     phonebook.Add("Sofia", "5935820958");

            //.CLEAR - clears the whole dictionary


            //    //FOREACH - we reach his elements - but they are couples of KEY AND VALUE
            //    foreach (var item in phonebook)
            //    {
            //        //Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            //        //or:
            //        Console.WriteLine(item.Key);
            //        Console.WriteLine(item.Value);
            //    }

            //we can enumerate the names when printing - lets say in alphabetical order if it is a sorted Dictionary
            //foreach (var name in phonebook.Keys) //SORTED: phonebook.Keys.OrderBy(k => k) or OrderByDescending(k => k)
            //{
            //    Console.WriteLine(name); // this is the key
            //    Console.WriteLine("{0} -> {1}", name, phonebook[name]); - searches the value by keys (names)
            //}

            //we can scan val in phonebook.Values and print only them as well

            //WE CANNOT USE FOR - the keys have no indexes
            //for (int i = 0; i < phonebook.Keys.Count; i++)
            //{
            //    Console.WriteLine(phonebook.Keys[i]);
            //}

            //counting strings with int - foreach word in words - phonebook[word] = 0; (created the dictionary); second foreach - phonebook[word]++ (counting the values);

            //ARRAY VS DICTIONARY:

            //var arr = new int[10];
            //arr[5] = 50;
            //Console.WriteLine(arr[5]);

            //var dict = new Dictionary<int, int>(); //this means the key is int, and the value is also int
            //dict[5] = 50;
            //Console.WriteLine(dict[5]);

            //var dict2 = new Dictionary<string, int>(); //this means the key is int, and the value is also int
            //dict2["pesho"] = 50;
            //Console.WriteLine(dict2["pesho"]);

            //Names in different langueages: PHP, JS: associative arrays, JAVA: map, C#: dictionaries

            //We can use <string, int> and map a name of a person to his grade, ot to his phonenumber
            //We can map a person name to a contact(data structure with address, number, mail etc.)

            //Dictionaries are associative arrays, we are mapping a key towards a value
            //Keys play the role of indexes of the boxes in the array
            //We are making something like an array but the indexes are not 0123.. but some words: Pesho, Gosho, etc.
            //Dictionary<Key, Value> - we are mapping(like int.Parse) and giving it a value - The elemet Pesho has 6, the element Gosho has 7, etc.
            //MAPPING - means transforming data - saotvetstvie
            //Phonebook: Maria, 0887988322 - key, value
            //THE KEY HAS TO BE UNIQUE, we cannot duplicate it

            //LINQ is a technology, unique for c# - Filtering, Mapping, Ordering - LanguageIntegratedQuiery - f(x) -> y
            //We can make queries - questions - inside, using some structures of data

            //THE VALUE CAN BE A LIST - var phonebook = new Dictionary<string, List<string>>();
            //phonebook["Nakov"] = new List<string> { "683737", "Sofia" };
        }
    }
}
