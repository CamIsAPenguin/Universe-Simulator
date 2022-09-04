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

            using(StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.WriteLine(ContentsToWrite);
            }
            string read = File.ReadAllText(FilePath);
            Console.WriteLine(read);
            Console.ReadLine();


            
        }
    }
}