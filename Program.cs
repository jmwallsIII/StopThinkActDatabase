namespace StopThinkAct
{


    internal class Program
    {

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        static string TimeReference()
        {
            string now = DateTime.Now.ToString();
            return now;
        }
        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU: STOP.THINK.ACT");
            Console.WriteLine("1) ADD NEW EVENT");
            Console.WriteLine("2) VIEW ALL EVENTS");
            Console.WriteLine("3) EXIT APPLICATION");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())     //FIRST SWITCH STATEMENT
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("ADD NEW EVENT:");
                    Console.WriteLine("1) Continue");
                    Console.WriteLine("2) Return to MAIN MENU");
                    Console.WriteLine("3) EXIT APPLICATION");
                    Console.WriteLine("invalid option will revert to MAIN MENU");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())     //SECONDARY SWITCH STATEMENT
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("PLEASE INCLUDE THE FOLLOWING DETAILS:");
                            Console.WriteLine("1) A brief description of what was observed" + Environment.NewLine + "2) Causes or contributing factors" + Environment.NewLine + "3) Actions taken or improvement suggestions" + Environment.NewLine);
                            Console.WriteLine("NOTE: Press enter key after input for each requested detail" + Environment.NewLine);
                            Console.WriteLine("Proceed:");
                            Console.Write("1."); File.AppendAllText(@"example.txt", TimeReference() + Environment.NewLine + "1." + Console.ReadLine() + Environment.NewLine);
                            Console.Write("2."); File.AppendAllText(@"example.txt", "2." + Console.ReadLine() + Environment.NewLine);
                            Console.Write("3."); File.AppendAllText(@"example.txt", "3." + Console.ReadLine() + Environment.NewLine);
                            Console.Clear();
                            Console.WriteLine("Thank you!  Press ENTER key to return to MAIN MENU");
                            switch (Console.ReadLine())    //tertiary switch 
                            {
                                default:
                                    return MainMenu();   //tertiary switch end
                            }
                        case "2":
                            return true;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("PRESS ANY KEY TO EXIT");
                            Environment.Exit(0);
                            return false;
                        default:
                            return MainMenu();                //END SECONDARY SWITCH STATEMENT
                    }
                case "2":
                    Console.Clear();
                    Console.WriteLine("VIEW ALL EVENTS");
                    Console.WriteLine("1) Continue");
                    Console.WriteLine("2) Return to MAIN MENU");
                    Console.WriteLine("3) EXIT APPLICATION");
                    Console.WriteLine("invalid option will revert to MAIN MENU");
                    Console.Write("\r\nSelect an option: ");
                    switch (Console.ReadLine())     //SECONDARY SWITCH STATEMENT
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("START CURRENT ENTRIES:");
                            Console.WriteLine(File.ReadAllText(@"example.txt"));
                            Console.WriteLine("END CURRENT ENTRIES:  Press ENTER key to return to MAIN MENU");
                            switch (Console.ReadLine())    //tertiary switch 
                            {
                                default:
                                    return MainMenu();   //tertiary switch end
                            }
                        case "2":
                            return true;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("PRESS ANY KEY TO EXIT");
                            Environment.Exit(0);
                            return false;
                        default:
                            return MainMenu();      //END SECONDARY SWITCH STATEMENT
                    }
                case "3":           //FIRST SWITCH STATEMENT
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
