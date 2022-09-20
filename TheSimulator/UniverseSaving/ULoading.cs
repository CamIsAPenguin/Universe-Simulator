using System;
namespace LoadFile
{
    public class LoadYear
    {
        public static char[] LoadYears(string FileName)
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
                    char[] years = getyears(amountofnums, FileName);
                    return years;
                }
            }
        }
        private static char[] getyears(int amountofnums, string filename)
        {
            string contents = File.ReadAllText(filename);
            int startLine = contents.IndexOf("Start Years");
            startLine = startLine+13;
            char[] years = new char[amountofnums];

            


            for(int i = 0; i != amountofnums; i++)
            {
                //add to years here
                char CurrentLine = contents[startLine];
                startLine++;
                years[i] = CurrentLine;
            }
            return years;

            
            
        }
    }
}