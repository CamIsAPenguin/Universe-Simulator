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
            char[] currentline = {filecontents[StartLine]};
            StartLine++;
            
            while(true)
            {

                int amountofyears = StartLine;
                amountofyears++;
                if(currentline.Contains('.'))
                {
                    
                    while(true)
                    {
                        char[] NumOfYears = new char[amountofyears];
                        int i = 1;
                        string FileContents = File.ReadAllText(FileName);
                        int startline = filecontents.IndexOf("Start Years");
                        startline = startline+13;

                        while(true)
                        {
                            NumOfYears[i] = filecontents[startline];
                            startline++;
                            i++;
                            if(i != amountofyears)
                            {
                                return NumOfYears;
                            }
                        }
                        
                    }
                }
            }

            
            
        }
    }
}