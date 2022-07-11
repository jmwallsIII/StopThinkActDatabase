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
                    Console.Clear ();
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
                        File.AppendAllText(@"example.txt", Console.ReadLine() + Environment.NewLine);
                        Console.ReadLine();
                            return false;             
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
                            Console.WriteLine("CURRENT ENTRIES");
                        Console.WriteLine(File.ReadAllText(@"example.txt"));
                            return false;
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
