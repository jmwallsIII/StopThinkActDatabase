using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopThinkAct
{

    internal class MainMenu
    {
        static string TimeReference()
        {
            string now = DateTime.Now.ToString();
            return now;
        }
        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU: STOP.THINK.ACT" + Environment.NewLine);
            Console.WriteLine("1) ADD NEW EVENT");
            Console.WriteLine("2) VIEW ALL EVENTS");
            Console.WriteLine("3) EXIT APPLICATION");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())     // BEGINNING FIRST SWITCH STATEMENT
            {

                case "1":
                    Console.Clear();
                    Console.WriteLine("ADD NEW EVENT:" + Environment.NewLine);
                    Console.WriteLine("1) Continue");
                    Console.WriteLine("2) Return to MAIN MENU");
                    Console.WriteLine("3) EXIT APPLICATION" + Environment.NewLine);
                    Console.WriteLine("invalid option will revert to MAIN MENU");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())     //SECONDARY SWITCH STATEMENT #1
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("PLEASE INCLUDE THE FOLLOWING DETAILS:");
                            Console.WriteLine("1) A brief description of what was observed" + Environment.NewLine + "2) Causes or contributing factors" + Environment.NewLine + "3) Actions taken or improvement suggestions" + Environment.NewLine);
                            Console.WriteLine("NOTE: Press enter key after input for each requested detail" + Environment.NewLine);
                            Console.WriteLine("Proceed:");
                            Console.Write("1."); File.AppendAllText(@"eventsfile.txt", TimeReference() + Environment.NewLine + "1." + Console.ReadLine() + Environment.NewLine);
                            Console.Write("2."); File.AppendAllText(@"eventsfile.txt", "2." + Console.ReadLine() + Environment.NewLine);
                            Console.Write("3."); File.AppendAllText(@"eventsfile.txt", "3." + Console.ReadLine() + Environment.NewLine);
                            Console.Clear();
                            Console.WriteLine("Thank you!  Press ENTER key to return to MAIN MENU");
                            switch (Console.ReadLine())    //begin tertiary switch 
                            {
                                default:
                                    return Menu();   //end tertiary switch 
                            }
                        case "2":
                            return true;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("PRESS ANY KEY TO EXIT");
                            Environment.Exit(0);
                            return false;
                        default:
                            return Menu();                //END SECONDARY SWITCH STATEMENT #1
                    }
                case "2":
                    Console.Clear();
                    Console.WriteLine("VIEW ALL EVENTS" + Environment.NewLine);
                    Console.WriteLine("1) Continue");
                    Console.WriteLine("2) Return to MAIN MENU");
                    Console.WriteLine("3) EXIT APPLICATION" + Environment.NewLine);
                    Console.WriteLine("invalid option will revert to MAIN MENU");
                    Console.Write("\r\nSelect an option: ");
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
                                    return Menu();   // end tertiary switch 
                            }
                        case "2":
                            return true;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("PRESS ANY KEY TO EXIT");
                            Environment.Exit(0);
                            return false;
                        default:
                            return Menu();      //END SECONDARY SWITCH STATEMENT #2
                    }
                case "3":           
                    Console.Clear();
                    Console.WriteLine("PRESS ANY KEY TO EXIT");
                    Environment.Exit(0);
                    return false;
                default:
                    return true;        //END FIRST SWITCH STATEMENT
            }

        }
    }
}
