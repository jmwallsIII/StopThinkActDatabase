using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopThinkAct
{
    public class AltMenu
    {
      
        public static bool AlternateMenu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU: STOP.THINK.ACT" + Environment.NewLine);
            Console.WriteLine("1.) VIEW ALL EVENTS");
            Console.WriteLine("2.) EXIT APPLICATION");
            Console.WriteLine("3.) CHOOSE DIFFERENT USER");
            Console.Write(Environment.NewLine + "Select an option: ");
            switch (Console.ReadLine())
            {     // BEGINNING FIRST SWITCH STATEMENT
                case "1":
                    Console.Clear();
                    Console.WriteLine("VIEW ALL EVENTS" + Environment.NewLine);
                    Console.WriteLine("1) Continue");
                    Console.WriteLine("2) Return to MAIN MENU");
                    Console.WriteLine("3) EXIT APPLICATION" + Environment.NewLine);
                    Console.WriteLine("invalid option will revert to MAIN MENU");
                    Console.Write(Environment.NewLine + "Select an option: ");
                    switch (Console.ReadLine())     //SECONDARY SWITCH STATEMENT #2
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("START CURRENT ENTRIES:");
                            Console.WriteLine(File.ReadAllText(@"eventsfile.txt"));
                            Console.WriteLine("END CURRENT ENTRIES:  Press ENTER key to return to MAIN MENU");
                            switch (Console.ReadLine())    // begin tertiary switch 
                            {
                                default:
                                    return AlternateMenu();   // end tertiary switch 
                            }
                        case "2":
                            return AlternateMenu();
                        case "3":
                            Console.Clear();
                            Console.WriteLine("PRESS ANY KEY TO EXIT");
                            Environment.Exit(0);
                            return false;
                        default:
                            return AlternateMenu();      //END SECONDARY SWITCH STATEMENT #2
                    }
                case "2":
                    Console.Clear();
                    Console.WriteLine("PRESS ANY KEY TO EXIT");
                    Environment.Exit(0);
                    return false;
                case "3":
                    Console.Clear();
                    return SelectUser.SelectionPrompt();
                default:
                    return AlternateMenu();
            }

        }
    }
}
