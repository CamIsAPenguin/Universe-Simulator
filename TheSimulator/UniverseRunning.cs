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
                THEUNIVERSE.TheUniverse(UName);
                
            
        }

    }


    internal class THEUNIVERSE
    {
        
        public static string FolderPath, ConfigFile, UNumsFile, CivilizationsFiles;
        public static string numofspec, numofplanets, numofintellife, numofcivs, Event, Event2, Event3;
        public static bool firstyear;
        public static string numofyears = "0";
        internal static void TheUniverse(string UniverseName)
        {
            char[] Alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'x', 'x', 'y', 'z'};
            char[] nums = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            Console.WriteLine("====================================================================================");
            string NumOfSpecStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"NUMBER OF SPECIES: {numofspec}");
            string NumOfPlanetsStats = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"NUMBER OF PLANETS: {numofplanets}");
            string NumOfIntelLifeStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"NUMBER OF INTELLEGENT LIFE: {numofintellife}");
            string NumOfCivsStat = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"NUMBER OF CIVILIZATIONS: {numofcivs}");
            string NumOfYearsStats = Convert.ToString(Console.GetCursorPosition());
            Console.WriteLine($"YEAR: {numofyears}");
            Console.WriteLine("====================================================================================");
            Console.WriteLine("");
            Console.WriteLine("====================================================================================");
            Console.WriteLine("                          Universe Events");
            Console.WriteLine("====================================================================================");
            Console.WriteLine($"Year 0: Creation of {UniverseName}");
            string Event1Location;
            Console.WriteLine("");
            string Event2Location;
            Console.WriteLine("");
            string Event3Location;
            Console.WriteLine("====================================================================================");
            Console.WriteLine("");
            string CMDLine = Convert.ToString(Console.GetCursorPosition());
            Console.Write("CMD: ");
            //Console.WriteLine("");

            while(true)
            {
                string CMD = Console.ReadLine();
                CMD.ToLower();
                bool result;
                int a;
                result = int.TryParse(CMD, out a);

                if(result == true)
                {
                    double YearsPassing = Double.Parse(CMD);
                    AdvanceUniverse(YearsPassing, NumOfYearsStats, CMDLine, UniverseName, numofyears, FolderPath, UNumsFile);
                }
                else if(CMD == "s")
                {
                    ForceSave();
                }
                else if(CMD == "q")
                {
                    Quit();
                }
                else
                {
                    Console.Clear();
                    TheUniverse(UniverseName);
                }
                

            }

        }

        //advance the simulation
        public static void AdvanceUniverse(double yearspassing, string yearspos, string beforepos, string Uname, string pastyear, string FolderPath, string numfile)
        {
            string FileName = USaving.Save.GetFile(FolderPath, numfile);            
            LoadFile.FileLoad.LoadYears(FileName);
            


        }
        //advance the simulation

        public static void Quit()
        {
            Start.Startup.Main();
        }
        public static void ForceSave()
        {
            
        }
        public static void ChangeCursorPos(string CursorPos, string beforePos, string WhatToWrite, string UName)
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
            Console.Clear();
            THEUNIVERSE.TheUniverse(UName);
            


        }

    }


    }