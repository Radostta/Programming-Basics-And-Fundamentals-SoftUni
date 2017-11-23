﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

            int entryCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < entryCount; i++)
            {
                string[] entryArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string ip = entryArgs[0];
                string userName = entryArgs[1];
                int duration = int.Parse(entryArgs[2]);

                InsertUserName(userLogs, userName);
                InsertIpAndDuration(userLogs, userName, ip, duration);
            }
            PrintUSerLogs(userLogs);            
        }

        private static void PrintUSerLogs(SortedDictionary<string, SortedDictionary<string, int>> userLogs)
        {
            foreach (var userEntry in userLogs)
            {
                string userName = userEntry.Key;
                int durationTotal = userEntry.Value.Values.Sum();
                List<string> userIps = userEntry.Value.Keys.ToList();

                Console.WriteLine($"{userName}: {durationTotal} [{string.Join(", ", userIps)}]");
            }
        }

        private static void InsertIpAndDuration(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName, string ip, int duration)
        {
            if (!userLogs[userName].ContainsKey(ip))
            {
                userLogs[userName].Add(ip, 0);
            }
            userLogs[userName][ip] += duration;
        }

        private static void InsertUserName(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName)
        {
            if (!userLogs.ContainsKey(userName))
            {
                userLogs.Add(userName, new SortedDictionary<string, int>());
            }
        }
    }
}
