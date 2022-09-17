using System;
namespace LoadFile
{
    public class FileLoad
    {
        public static char[] LoadYears(string FileName)
        {
            //only been getting the first number
            string filecontents = File.ReadAllText(FileName);
            int StartLine = filecontents.IndexOf("Start Years");
            StartLine = StartLine+13;

            int Years = StartLine;

            while(true)
            {
                char line = filecontents[Years];
                Years++;
                char[] FinalYears = {line};
                if(line != '.')
                {
                    return FinalYears;
                }
            }
            
        }
    }
}