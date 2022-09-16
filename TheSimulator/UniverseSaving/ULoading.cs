using System;
namespace LoadFile
{
    public class FileLoad
    {
        public static char[] LoadYears(string FileName)
        {
            //not getting all the nums
            string filecontents = File.ReadAllText(FileName);
            int StartLine = filecontents.IndexOf("Start Years");
            StartLine = StartLine+13;
            int Years = StartLine;
            

            for(int i = Years; true ; i++)
            {
                
                char line = filecontents[i];
                char[] FinalYears = {line};
                if(line == ' ')
                {
                    return FinalYears;
                }
                else
                {
                    return FinalYears;
                }
            }
            
        }
    }
}