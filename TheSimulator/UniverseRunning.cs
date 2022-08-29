using System;

namespace Universe
{
    public class RunningUniverse
    {
        public static void Years(string UName)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Welcome to {UName}, to exit this universe and return to command selection enter \"q\"");
            Console.WriteLine("To advance the Simulation enter the amount of megannums (1 million years) to pass");
            Console.WriteLine("------------------------------------------------------");
            
        }
    }
}