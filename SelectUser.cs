using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopThinkAct
{

    public class SelectUser : Usernames
    {
        public static bool SelectionPrompt()
        {
            Usernames user1 = new Usernames();
            user1.User = "John";
            Usernames user2 = new Usernames();
            user2.User = "Tyler";
            Usernames user3 = new Usernames();
            user3.User = "Tester";
            Usernames user4 = new Usernames();
            user4.User = "Guest -view only-";

            Console.WriteLine("Choose a user");
            Console.WriteLine("1.) " + user1.User);
            Console.WriteLine("2.) " + user2.User);
            Console.WriteLine("3.) " + user3.User);
            Console.WriteLine("4.) " + user4.User);  // create alt menu for viewing
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Are you " + user1.User + " ?");
                    Console.WriteLine("1.) Yes");
                    Console.WriteLine("2.) No");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();                      
                            File.AppendAllText(@"eventsfile.txt", Environment.NewLine + "USER:John:" + Environment.NewLine);
                            return false;
                        case "2":
                            Console.Clear();
                            return true;
                        default:
                            Console.Clear();
                            Console.WriteLine("INVALID CHOICE");
                            return true;
                    }
                    
                case "2":
                    Console.Clear();
                    Console.WriteLine("Are you " + user2.User + " ?");
                    Console.WriteLine("1.) Yes");
                    Console.WriteLine("2.) No");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            File.AppendAllText(@"eventsfile.txt", TimeReference() + Environment.NewLine + "1." + Console.ReadLine() + Environment.NewLine);
                            return false;
                        case "2":
                            Console.Clear();
                            return true;
                        default:
                            Console.Clear();
                            Console.WriteLine("INVALID CHOICE");
                            return true;
                    }
                    
                case "3":
                    Console.Clear();
                    Console.WriteLine("Are you " + user3.User + " ?");
                    Console.WriteLine("1.) Yes");
                    Console.WriteLine("2.) No");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            File.AppendAllText(@"eventsfile.txt", TimeReference() + Environment.NewLine + "1." + Console.ReadLine() + Environment.NewLine);
                            return false;
                        case "2":
                            Console.Clear();
                            return true;
                        default:
                            Console.Clear();
                            Console.WriteLine("INVALID CHOICE");
                            return true;
                    }
                    
                default:
                    Console.Clear();
                    return SelectionPrompt();

            }
        }
    }
}
