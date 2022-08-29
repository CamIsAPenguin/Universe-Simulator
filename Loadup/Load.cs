using System;

namespace Start
{
    public class Startup
    {
        public static void Main()
        {
            Console.Write("Welcome,");
            Console.WriteLine(" please enter a valid command");
            Console.WriteLine("------------------------------");
            Console.WriteLine("NEW - create a new universe");
            Console.WriteLine("LOAD - loads a save universe");
            Console.WriteLine("ULIST - shows all saved universes");
            Console.WriteLine("DELETE - delete a saved universe");
            Console.WriteLine("HELP - display information on command usage");
            string? StartCMD = Console.ReadLine();
            StartCMD.ToUpper();

            switch(StartCMD)
            {
                case "NEW":
                    Setup.UniverseConfiguration.SetSaveLocation();
                break;
                case "LOAD":

                break;
                case "ULIST":

                break;
                case "DELETE":

                break;
                case "HELP":
                    HELP();
                break;
            }
        }

        internal static void HELP()
        {
            Console.WriteLine("NEW - just \"NEW\"");
            Console.WriteLine("LOAD (Universe Name) - type \"LOAD\" and a universe name");
            Console.WriteLine("ULIST \"ULIST\"");
            Console.WriteLine("DELETE (Universe name) - type \"DELETE\" and a universe name");
        }

    }
}