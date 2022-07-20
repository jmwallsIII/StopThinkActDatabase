using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopThinkAct
{
    public class Usernames
    {
        public string user1 = "john";
        public string user2 = "stew";
        public string user3 = "tester";

        public void SelectionPrompt()
        {
         
            Console.WriteLine("Choose a user");
            Console.WriteLine("1" + user1);
            Console.WriteLine("2" + user2);
            Console.WriteLine("3" + user3);
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("");
                    return;
                    case "2":
                    return;
                    case"3":
                    return;
                default:
                    return SelectionPrompt();

            }
        }
    }
}
