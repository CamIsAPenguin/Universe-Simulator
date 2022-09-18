using System;
namespace LoadFile
{
    public class LoadYear
    {
        public static void LoadYears(string FileName)
        {
            //only been getting the first number
            string filecontents = File.ReadAllText(FileName);
            int StartLine = filecontents.IndexOf("Start Years");
            StartLine = StartLine+13;
            char currentline = filecontents[StartLine];
            
            while(true)
            {
                currentline = filecontents[StartLine];
                StartLine++;
                int amountofnums = 0;
                amountofnums++;
                if(currentline == '.')
                {
                    getyears(amountofnums, FileName);
                }
            }
        }
        private static void getyears(int amountofnums, string filename)
        {
            string contents = File.ReadAllText(filename);
            int startLine = contents.IndexOf("Start Years");
            startLine = startLine+13;
            char[] years;

            char[] CurrentLine = {contents[startLine]};
            years = CurrentLine;


            for(int i = 1; i != amountofnums; i++)
            {
                //add to years here
            }
            
        }
    }
}