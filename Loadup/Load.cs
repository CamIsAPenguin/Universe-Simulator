using System;
using USaving;
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
                case "HELP":
                    HELP();
                break;
                default:
                    Console.WriteLine("ERROR NOT A VALID COMMAND");
                    Main();
                break;
            }
        }

        internal static void HELP()
        {
            Console.WriteLine("NEW - just \"NEW\"");
            Console.WriteLine("LOAD (Universe's Folder Path) - type \"LOAD\" and a universe's folder's path");
            Console.WriteLine("-------------------------------------");
            Main();
        }

    }
}