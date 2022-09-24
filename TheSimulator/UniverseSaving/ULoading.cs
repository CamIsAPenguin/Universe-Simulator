using System;
using System.Linq;
namespace LoadFile
{
    public class LoadYear
    {
        public static string LoadYears(string FileName)
        {
            //only been getting the first number
            string filecontents = File.ReadAllText(FileName);
            int StartLine = filecontents.IndexOf("Start Years");
            StartLine+=13;
            char currentline = filecontents[StartLine];
            int amountofnums = 0;
            while(true)
            {
                currentline = filecontents[StartLine];
                StartLine++;

                amountofnums++;
                if(currentline == '.')
                {
                    string years = getyears(amountofnums, FileName);
                    return years;
                }
            }
        }
        private static string getyears(int amountofnums, string filename)
        {
            string contents = File.ReadAllText(filename);
            int startLine = contents.IndexOf("Start Years");
            startLine = startLine+13;
            char[] years = new char[amountofnums];
            string FinalYear = " ";

            


            for(int i = 1; i != amountofnums; i++)
            {
                //add to years here
                char CurrentLine = contents[startLine];
                startLine++;
                years[i] = CurrentLine;
            }
            var count = years.Count();
            for(int b = 0; b != count; b++) //something wrong here
            {
                string x = Convert.ToString(years[b]);
                FinalYear += x;
            }
            return FinalYear;

            
            
        }
    }
}