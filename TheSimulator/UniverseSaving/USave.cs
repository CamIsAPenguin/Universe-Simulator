using System;
using System.IO;
using System.Text;

namespace USaving
{
    public class Save
    {
        public static void CreateAndWrite(string FolderPath, string FileName, string ContentsToWrite)
        {
            //CreateFile
            string FilePath = FolderPath + "\\" + FileName; 
            Console.WriteLine(FileName);
            //CreateFile

            //WriteFile
            using(StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(ContentsToWrite);
            }
            //string read = File.ReadAllText(FilePath);
            //WriteFile
        }
        public static string GetFile(string FolderPath, string FileName)
        {
            //FolderPath is not being added
            string FilePath = FolderPath + "\\" + FileName;
            return FilePath;
        }
    }
}