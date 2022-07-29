using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopThinkAct                                                       // inheritance used here from username class (getting and setting names for username user objects)
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
            Console.WriteLine("4.) " + user4.User);  
            Console.WriteLine("5.) EXIT APPLICATION");
            Console.Write(Environment.NewLine + "Select an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Are you " + user1.User + " ?");
                    Console.WriteLine("1.) Yes");
                    Console.WriteLine("2.) No");
                    Console.Write(Environment.NewLine + "Select an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();                      
                            File.AppendAllText(@"eventsfile.txt", Environment.NewLine + "USER:John:" + Environment.NewLine);
                            return MainMenu.Menu();
                        case "2":
                            Console.Clear();
                            return SelectionPrompt();
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
                    Console.Write(Environment.NewLine + "Select an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            File.AppendAllText(@"eventsfile.txt", Environment.NewLine + "USER:Tyler:" + Environment.NewLine);
                            return MainMenu.Menu();
                        case "2":
                            Console.Clear();
                            return SelectionPrompt();
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
                    Console.Write(Environment.NewLine + "Select an option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            File.AppendAllText(@"eventsfile.txt", Environment.NewLine + "USER:TESTER:" + Environment.NewLine);
                            return MainMenu.Menu();
                        case "2":
                            Console.Clear();
                            return SelectionPrompt();
                        default:
                            Console.Clear();
                            Console.WriteLine("INVALID CHOICE");
                            return true;
                    }
                case "4":
                    Console.Clear();
                    return AltMenu.AlternateMenu();
                   

                case "5":
                    Console.Clear();
                    Console.WriteLine("PRESS ANY KEY TO EXIT");
                    Environment.Exit(0);
                    return false;


                default:
                    Console.Clear();
                    return SelectionPrompt();

            }
        }
    }
}
