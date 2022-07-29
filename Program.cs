namespace StopThinkAct
{


    public class Program
    {

        static void Main(string[] args)
        {
            
            
            Logo.DisplayLogo();
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine); //just trying to create some space between title and text
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey(true);
            Console.Clear();
            bool showSelectUser = true;
            while (showSelectUser)

            {
                showSelectUser = SelectUser.SelectionPrompt();
            }
            bool showMenu = true;
            while (showMenu)

            {
                showMenu = MainMenu.Menu();
            }
    
        }
        
    }
}