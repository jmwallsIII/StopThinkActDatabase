namespace StopThinkAct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program is used to record \"Stop.Think.Act\" near miss observations.");
            Console.WriteLine("Are you ready to continue?");
            string Continue = Console.ReadLine();
            if (Continue == "yes" || Continue == "Yes" || Continue == "yes " || Continue == "Yes ")
            {
                Console.WriteLine("What is your first and last name?");
            }   
            else
            {
                Console.WriteLine("You can terminate this program by exiting at the top right corner, or by pressing any key.");
                Environment.Exit(0);
            }
            string Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name + ",");
            Console.WriteLine("Please provide the date you witnessed the incident that you are reporting today; using mm/dd/yyyy format...");
            string Dateobs = Console.ReadLine();
            Console.WriteLine("is this the correct date? " + Dateobs + ". . . ");

     

            Console.ReadLine();
        }
    }
}