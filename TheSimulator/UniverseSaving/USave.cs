using System;
using System.IO;
using System.Text;

namespace USaving
{
    public class Save
    {
        public static async void SaveInfo(string FolderPath)
        {
            //Create Specific Univere Configuration
            string FolderTXT = FolderPath + "\\UniverseConfig.txt"; 
            Console.WriteLine(FolderTXT);
            using(FileStream ConfigFile = File.Create(FolderTXT))
            
            File.WriteAllLines(FolderPath, );
            Console.ReadLine();
            
        }
    }
}