using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            //READ:
            var users = new Dictionary<string, Dictionary<string, int>>(); //username -> (ip -> ip count)
                                                                           //count++ each time we have the user and this ip
            while (true)
            {                
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] commandArgs = line.Split(' '); //ip message username

                string name = commandArgs[2].Replace("user=", ""); //deleting user= and leaving only the name
                string ip = commandArgs[0].Replace("IP=", "");
                
                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());
                }
                if (!users[name].ContainsKey(ip)) //this is the nested dictionary ip -> ip count
                {
                    users[name].Add(ip, 0); //we add the ip and set its ip count to 0
                }

                users[name][ip] = users[name][ip] + 1; //increasing the count of an existing name and ip                
            }

            //PRINT:
            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key + ": ");

                StringBuilder sb = new StringBuilder();

                foreach (var ipAndCount in user.Value)
                {
                    sb.Append(ipAndCount.Key).Append(" => ").Append(ipAndCount.Value + ", ");
                    //Console.WriteLine($"{ipAndCount.Key} => {ipAndCount.Value}, "); //has to have dot at the end
                }

                sb.Remove(sb.Length - 2, 2); //removing the last symbol -> by default the length is Length - 1
                sb.Append(".");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
