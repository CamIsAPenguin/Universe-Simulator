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
                        string ConfigFile = "UniverseConfig.txt";
                        string UniverseNums = "UniverseNums.txt";
                        string Contents = "Universe Name: " + ConfirmedUniverseName;
                        string UniverseNumsContents = "Year: 0";
                        USaving.Save.CreateAndWrite(SaveLocation, UniverseNums, UniverseNumsContents);
                        USaving.Save.CreateAndWrite(SaveLocation,ConfigFile,Contents);
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
                //Config files
                string ConfigFile = "UniverseConfig.txt";
                string Contents = "Universe Name: " + UName + " endline";
                USaving.Save.CreateAndWrite(slocation,ConfigFile,Contents);
                //Config files

                //UNums files
                string UNums = "UniverseNums.txt";
                string UNumsContents = "Start Years: 1000. Yearsendline" + Environment.NewLine + "Start NumOfSpecies: 0 Speciesendline" + Environment.NewLine + " Start NUMOfPlanets: 0 PlanetsendLine" + Environment.NewLine + "Start NUMofIntelLife: 0 IntelLifeendline" + Environment.NewLine + "Start NumOfCivilizations: 0 Civsendline";
                USaving.Save.CreateAndWrite(slocation, UNums, UNumsContents);
                //UNums files

                //CivilizationsFiles
                string CivsFiles = "UniverseCivs.txt";
                string CivsFilesContents = "not civs endline";
                USaving.Save.CreateAndWrite(slocation, CivsFiles, CivsFilesContents);
                //CivilizationsFiles

                

                //set universe files
                Universe.THEUNIVERSE.ConfigFile = ConfigFile;
                Universe.THEUNIVERSE.UNumsFile = UNums;
                Universe.THEUNIVERSE.CivilizationsFiles = CivsFiles;
                Universe.THEUNIVERSE.FolderPath = slocation;
                Universe.RunningUniverse.Direction(UName);
            }
        }
    }
}