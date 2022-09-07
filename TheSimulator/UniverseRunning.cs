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
        public static int numofspec, numofplanets, numofintellife, numoflife, numofcivs,numofyears;
        internal static void TheUniverse(string YearsPassing)
        {
            char[] Alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'x', 'x', 'y', 'z'};
            char[] nums = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            Console.WriteLine("====================================================================================");
            string NumOfSpecStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"NUMBER OF SPECIES: {numofspec}");
            string NumOfPlanetsStats = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"NUMBER OF PLANETS: {numofplanets}");
            string NumOfLifeStats = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"Number OF LIFE: {numoflife}");
            string NumOfIntelLifeStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"NUMBER OF INTELLEGENT LIFE: {numofintellife}");
            string NumOfCivsStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"NUMBER OF CIVILIZATIONS: {numofcivs}");
            string NumOfYearsStats = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"YEAR: {numofyears}");
            Console.WriteLine("====================================================================================");

            Console.WriteLine("CMD: ");

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
            if()
        }
        public static void ChangeCursorPos(string CursorPos, string WhatToWrite)
        {
            string beforePos = Convert.ToString(Console.GetCursorPosition());
            string[] splitbeforePos = beforePos.Split();
            int beforelength = splitbeforePos[1].Length;
            beforelength--;
            string beforePos1 = splitbeforePos[1].Remove(beforelength,1);
            beforePos1 = beforePos.Remove(0,1);
            string beforePos2 = splitbeforePos[0].Remove(0,1);
            int ibeforePos1 = Convert.ToInt32(beforePos1);
            int ibeforePos2 = Convert.ToInt32(beforePos2);


            string[] splitPos = CursorPos.Split(',');
            int length = splitPos[1].Length;
            length--;
            string Pos1 = splitPos[1].Remove(length,1);
            Pos1 = Pos1.Remove(0,1);
            string Pos2 = splitPos[0].Remove(0,1);
            int iPos1 = Convert.ToInt32(Pos1);
            int iPos2 = Convert.ToInt32(Pos2);
            Console.SetCursorPosition(iPos1,iPos2);
            Console.Write(WhatToWrite);
            Console.SetCursorPosition(ibeforePos1,ibeforePos2);

        }
    }


    }