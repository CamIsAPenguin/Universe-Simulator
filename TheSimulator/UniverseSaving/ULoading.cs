namespace LoadFile
{
    public class FileLoad
    {
        public static void LoadYears(string FileName)
        {
            string filecontents = File.ReadAllText(FileName);
            int StartLine = filecontents.IndexOf("Start Years");
            StartLine = StartLine+13;
            int Years = StartLine;


            for(int i = Years; true ; i++)
            {
                
                char line = filecontents[i];
                if(line == ' ')
                {
                    break;
                }
                else
                {
                    char[] FinalYears = {line};
                    
                }
            }
            
        }
    }
}