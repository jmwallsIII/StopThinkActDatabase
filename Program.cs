namespace StopThinkAct
{


    internal class Program
    {

        static void Main(string[] args)
        {

            Logo.DisplayLogo();
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine); //just trying to create some space between title and text
            Console.WriteLine("PRESS ANY KEY TO CONTINUE TO CONTINUE");
            Console.ReadKey(true);
            Console.Clear();
            Usernames jw = new Usernames();
            jw.SelectionPrompt();
            Console.ReadLine();
            bool showMenu = true;
            while (showMenu)

            {
                showMenu = MainMenu.Menu();
            }
    
        }
        
    }
}
    




// create an object for writng text
//StreamWriter sw = new StreamWriter(@"file.txt", true);
// write a line
//sw.WriteLine();
// close the file
//sw.Close();