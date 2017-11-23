using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvertisementMessageUsingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new[]
            {
                "Diana", "Petya", "Stella", "Elena",
                "Katya", "Iva", "Annie", "Eva"
            };

            var cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            string dNframeworkInputPath = @"..\..\Input.txt";
            string input = File.ReadAllText(dNframeworkInputPath);

            string result = "";

            var count = int.Parse(input);
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                result += ($"{phrases[random.Next(0, phrases.Length)]} " +
                             $"{events[random.Next(0, events.Length)]} " +
                         $"{authors[random.Next(0, authors.Length)]} - " +
                             $"{cities[random.Next(0, cities.Length)]}") +
                                                   Environment.NewLine;
            }

            string dNframeworkOutputPath = @"..\..\Output.txt";
            File.WriteAllText(dNframeworkOutputPath, result);
        }
    }
}
