using System;
using System.IO;
namespace Setup
{
    public class UniverseConfiguration
    {
        public static bool runUniverse = false;
        public static string SaveLocation;

        public static void SetSaveLocation()
        {
            Console.WriteLine("Please enter a valid folder path to save all Universe files: ");
            SaveLocation = Console.ReadLine();
            
            bool FolderExists = Directory.Exists(SaveLocation);
            if(FolderExists == true)
            {
                Console.Write("Thank you, ");
                SetUniverseName();
            }
            else
            {
                Console.WriteLine("ERROR FOLDER NOT FOUND");
                SetSaveLocation();
            }
        }
        internal static void SetUniverseName()
        {
            Console.WriteLine("Please enter this Universe's name");
            string? UniverseName = Console.ReadLine();
            Console.WriteLine("Please reenter this Universe's name to confirm");
            string? ConfirmedUniverseName = Console.ReadLine();
            
            if(UniverseName == ConfirmedUniverseName)
            {
                Console.WriteLine("Thank you");
                while(true)
                {
                    Console.WriteLine("Would you like to load this Universe? (Y/N)");
                    string? ShouldLoadUniverse = Console.ReadLine();

                    if(ShouldLoadUniverse == "Y")
                    {
                        runUniverse = true;
                        ShouldRun(SaveLocation, ConfirmedUniverseName);
                        break;
                    }
                    if(ShouldLoadUniverse == "N")
                    {
                        Start.Startup.Main();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR INVALID OPTION");
                    }
                }

                
            }
            else
            {
                Console.WriteLine("ERROR UNIVERSE NAME DOES NOT MATCH");
            }
        } 
        internal static void ShouldRun(string slocation, string UName)
        {
            if (runUniverse == true)
            {
                string ConfigFile = "UniverseConfig.txt";
                string Contents = "Universe Name: " + UName;
                USaving.Save.CreateAndWrite(slocation,ConfigFile,Contents);
            }
        }
    }
}