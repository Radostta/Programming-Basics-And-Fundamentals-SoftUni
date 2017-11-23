using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails_Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailList = new Dictionary<String, String>(); // name, e-mail

            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }

                var email = Console.ReadLine();
                string domain = email.Substring(email.Length - 2); //starts from Length - 2; because there is no second parameter where to stop, takes till the end

                if (domain != "us" && domain != "uk")
                {
                    emailList.Add(name, email);
                    //emailList[name] = email;
                }                                
            }

            foreach (var contact in emailList)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }
        }
    }
}
