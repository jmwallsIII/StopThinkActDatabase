using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopThinkAct
{

    internal class MainMenu 
    {

        public static string TimeReference()
        {
            string now = DateTime.Now.ToString();
            return now;
        }
        public static bool Menu()
        {
            List<string> locations = new List<string>();
            locations.Add("ACID AREA");                                              //CREATED LIST. AND RETRIEVING VALUE AND USING IT IN PROGRAM.
            locations.Add("VAPORIZER");
            locations.Add("LOADING AREA");
            locations.Add("DENSER BUILDING");
            locations.Add("CONTROL ROOM");

            Console.Clear();
            Console.WriteLine("MAIN MENU: STOP.THINK.ACT" + Environment.NewLine);
            Console.WriteLine("1.) ADD NEW EVENT");
            Console.WriteLine("2.) VIEW ALL EVENTS");
            Console.WriteLine("3.) EXIT APPLICATION");
            Console.WriteLine("4.) CHOOSE DIFFERENT USER");
            Console.Write(Environment.NewLine + "Select an option: ");
            switch (Console.ReadLine())     
            {

                case "1":
                    Console.Clear();
                    Console.WriteLine("ADD NEW EVENT:" + Environment.NewLine);
                    Console.WriteLine("1) Continue");
                    Console.WriteLine("2) Return to MAIN MENU");
                    Console.WriteLine("3) EXIT APPLICATION" + Environment.NewLine);
                    Console.WriteLine("invalid option will revert to MAIN MENU");
                    Console.Write(Environment.NewLine + "Select an option: ");
                    switch (Console.ReadLine())     
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Please choose a location where you observed the event:");
                            Console.WriteLine("1." + locations[0]);                                                //RETRIEVING VALUES FROM LIST AND DISPLAYING THEM
                            Console.WriteLine("2." + locations[1]);
                            Console.WriteLine("3." + locations[2]);                                                 //I'm aware there is a nicer way to display these but its late and I can't get it to look exactly how i want so I did it the long way (foreach) blah blah
                            Console.WriteLine("4." + locations[3]);
                            Console.WriteLine("5." + locations[4]);
                            Console.WriteLine("invalid option will revert to MAIN MENU");
                            Console.Write(Environment.NewLine + "Select an option: ");


                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    File.AppendAllText(@"eventsfile.txt" , "LOCATION:" + locations[0] + Environment.NewLine);                   //here I am writing to a text file important details gathered from user
                                    break;
                                case "2":
                                    Console.Clear();
                                    File.AppendAllText(@"eventsfile.txt", "LOCATION:" + locations[1] + Environment.NewLine);
                                    break;
                                case "3":
                                    Console.Clear();
                                    File.AppendAllText(@"eventsfile.txt", "LOCATION:" + locations[2] + Environment.NewLine);
                                    break;
                                case "4":
                                    Console.Clear();
                                    File.AppendAllText(@"eventsfile.txt", "LOCATION:" + locations[3] + Environment.NewLine);
                                    break;
                                case "5":
                                    Console.Clear();
                                    File.AppendAllText(@"eventsfile.txt", "LOCATION:" + locations[4] + Environment.NewLine);
                                    break;
                                default: 
                                    return Menu();



                            }
                            

                            Console.WriteLine("PLEASE INCLUDE THE FOLLOWING DETAILS:");
                            Console.WriteLine("1) A brief description of what was observed" + Environment.NewLine + "2) Causes or contributing factors" + Environment.NewLine + "3) Actions taken or improvement suggestions" + Environment.NewLine);
                            Console.WriteLine("NOTE: Press enter key after input for each requested detail" + Environment.NewLine);
                            Console.WriteLine("Proceed:");
                            Console.Write("1."); File.AppendAllText(@"eventsfile.txt", TimeReference() + Environment.NewLine + "1." + Console.ReadLine() + Environment.NewLine);          //here I am writing to a text file important details gathered from user
                            Console.Write("2."); File.AppendAllText(@"eventsfile.txt", "2." + Console.ReadLine() + Environment.NewLine);
                            Console.Write("3."); File.AppendAllText(@"eventsfile.txt", "3." + Console.ReadLine() + Environment.NewLine);
                            Console.Clear();
                            Console.WriteLine("Thank you!  Press ENTER key to return to MAIN MENU");
                            switch (Console.ReadLine())    
                            {
                                default:
                                    return Menu();   
                            }
                        case "2":
                            return true;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("PRESS ANY KEY TO EXIT");
                            Environment.Exit(0);
                            return false;
                        default:
                            return Menu();                
                    }
                case "2":
                    Console.Clear();
                    Console.WriteLine("VIEW ALL EVENTS" + Environment.NewLine);
                    Console.WriteLine("1) Continue");
                    Console.WriteLine("2) Return to MAIN MENU");
                    Console.WriteLine("3) EXIT APPLICATION" + Environment.NewLine);
                    Console.WriteLine("invalid option will revert to MAIN MENU");
                    Console.Write(Environment.NewLine + "Select an option: ");
                    switch (Console.ReadLine())     
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("START CURRENT ENTRIES:");
                            Console.WriteLine(File.ReadAllText(@"eventsfile.txt"));              // here I am reading user inputed data from external text file
                            Console.WriteLine("END CURRENT ENTRIES:  Press ENTER key to return to MAIN MENU");
                            switch (Console.ReadLine())    
                            {
                                default:
                                    return Menu();   
                            }
                        case "2":
                            return Menu();
                        case "3":
                            Console.Clear();
                            Console.WriteLine("PRESS ANY KEY TO EXIT");
                            Environment.Exit(0);
                            return false;
                        default:
                            return Menu();      
                    }
                case "3":           
                    Console.Clear();
                    Console.WriteLine("PRESS ANY KEY TO EXIT");
                    Environment.Exit(0);
                    return false;
                case "4":
                    Console.Clear();
                    return SelectUser.SelectionPrompt();
                default:
                    return Menu();        
            }

        }
    }
}
