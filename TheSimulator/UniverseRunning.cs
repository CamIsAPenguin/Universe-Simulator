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
                THEUNIVERSE.TheUniverse(YearsToPass, UName);
                
            
        }

    }


    internal class THEUNIVERSE
    {
        public static string numofspec, numofplanets, numofintellife, numoflife, numofcivs,numofyears = "0", Event1, Event2, Event3;
        internal static void TheUniverse(string YearsPassing, string UniverseName)
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
            Console.WriteLine("");
            Console.Write("CMD: ");
            Console.WriteLine("");
            Console.WriteLine("====================================================================================");
            Console.WriteLine("                          Universe Events");
            Console.WriteLine("====================================================================================");
            Console.Write($"Year 0: Creation of {UniverseName}");
            string Event1Location;
            Console.Write("");
            string Event2Location;
            Console.Write("");
            string Event3Location;

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
                    if(CMD == "s")
                    {
                        ForceSave();
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
                    AdvanceUniverse(CMD, NumOfYearsStats);
                }
                else
                {
                    Console.WriteLine("ERROR, PLEASE ENTER A VALID COMMAND");
                }
            }

        }

        //advance the simulation
        public static void AdvanceUniverse(string yearspassing, string yearspos)
        {
            yearspassing = yearspassing + "000,000";
            numofyears = yearspassing;
            string beforePos = Convert.ToString(Console.GetCursorPosition());
            ChangeCursorPos(yearspos,beforePos, $"YEAR: {numofyears}");

        }
        //advance the simulation

        public static void Quit()
        {
            Start.Startup.Main();
        }
        public static void ForceSave()
        {
            
        }
        public static void ChangeCursorPos(string CursorPos, string beforePos, string WhatToWrite)
        {
            //beforePos = Convert.ToString(Console.GetCursorPosition());
            string[] splitPosBefore = beforePos.Split(',');
            int lengthbefore = splitPosBefore[1].Length;
            lengthbefore--;
            string Pos1before = splitPosBefore[1].Remove(lengthbefore,1);
            Pos1before = Pos1before.Remove(0,1);
            string Pos2before = splitPosBefore[0].Remove(0,1);
            int iPos1before = Convert.ToInt32(Pos1before);
            int iPos2before = Convert.ToInt32(Pos2before);



            string[] splitPos = CursorPos.Split(',');
            int length = splitPos[1].Length;
            length--;
            string Pos1 = splitPos[1].Remove(length,1);
            Pos1 = Pos1.Remove(0,1);
            string Pos2 = splitPos[0].Remove(0,1);
            int iPos1 = Convert.ToInt32(Pos1);
            int iPos2 = Convert.ToInt32(Pos2);

            Console.SetCursorPosition(iPos2,iPos1);
            Console.Write(WhatToWrite);
            Console.SetCursorPosition(iPos2before,iPos1before);
            Console.CursorLeft--;


        }
    }


    }