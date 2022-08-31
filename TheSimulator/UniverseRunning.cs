using System;

namespace Universe
{
    public class RunningUniverse
    {
        public static void Years(string UName, bool stop = false)
        {
            if(stop == false)
            {
                Console.WriteLine("=====================================================================================");
                Console.WriteLine($"Welcome to {UName}, to exit this universe and return to command selection enter \"q\", to save enter \"s\"");
                Console.WriteLine("To advance the Simulation enter the amount of megannums (1 million years) to pass");
                Console.WriteLine("====================================================================================");
                Console.WriteLine("");
                
            }

            
            while(stop == false)
            {
                string? CMD = Console.ReadLine();
                CMD.ToUpper();
                Quit(CMD, UName);
            }
            
        }
        public static void Quit(string CurrentCMD, string uname)
        {
            switch (CurrentCMD)
            {
                case "Q":
                    bool stop = true;
                    Years(uname, stop);
                    Start.Startup.Main();
                    // add case s to save
                break;
            }
        }
        internal static void UniverseStats()
        {
            
        }
    }
}