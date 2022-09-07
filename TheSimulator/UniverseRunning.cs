using System;

namespace Universe
{
    public class RunningUniverse
    {

        private static string YearsToPass;
        public static void Direction(string UName)
        {
                Console.WriteLine("=====================================================================================");
                Console.WriteLine($"Welcome to {UName}, to exit this universe and return to command selection enter \"q\", to save enter \"s\"");
                Console.WriteLine("To advance the Simulation enter the amount of megannums (1 million years) to pass");
                Console.WriteLine("====================================================================================");
                Console.WriteLine("");
                THEUNIVERSE.TheUniverse(YearsToPass);
                
            
        }

    }


    internal class THEUNIVERSE
    {
        internal static void TheUniverse(string YearsPassing)
        {
            char[] Alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'x', 'x', 'y', 'z'};
            char[] nums = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            Console.WriteLine("====================================================================================");
            string NumOfSpecStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine("NUMBER OF SPECIES: ");
            string NumOfPlanetsStats = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine("NUMBER OF PLANETS: ");
            string NumOfIntelLifeStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine("NUMBER OF INTELLEGENT LIFE:");
            string NumOfCivsStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine("NUMBER OF CIVILIZATIONS:");
            string NumOfYearsStats = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine("YEAR: ");
            Console.WriteLine("====================================================================================");

            while(true)
            {
                bool onlynums;
                var CMD = Console.ReadLine();
                CMD.ToLower();
                
                while(true)
                {
                    int i = 0;
                    char currentletter = Alphabet[i];
                    char currentnum = nums[i];
                    if(CMD.Contains(currentletter))
                    {
                        Console.WriteLine("ERROR, PLEASE ENTER A VALID COMMAND");
                    }
                    if(CMD.Contains(currentnum))
                    {
                        onlynums = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                    
                }   

                if(CMD == "q")
                {
                    Quit();
                }
                if(CMD == "s")
                {
                    ForceSave();
                }
                if(onlynums = true)
                {
                    AdvanceUniverse(CMD);
                }
                else
                {
                    Console.WriteLine("ERROR, PLEASE ENTER A VALID COMMAND");
                }
            }

        }

        //advance the simulation
        public static void AdvanceUniverse(string yearspassing)
        {
            //insert a lot of math here
        }
        //advance the simulation

        public static void Quit()
        {
            Start.Startup.Main();
        }
        public static void ForceSave()
        {
            //create and edit files that are needed
        }
    }


    }