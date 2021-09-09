using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ReadFileReverseOrder
{
  public class ReadFile
    {
        public String readFileReverse(string filepath)
        {
            string line = "";
            String revL = " ";
            
            ArrayList allLines = new ArrayList();
            try
            {

                StreamReader sr = new StreamReader(filepath);

                line = sr.ReadLine();    //Reading the first line of text
                allLines.Add(line);
                
                
                
                if (line == null)
                {
                    Console.WriteLine("Nothing to read!");
                    return null;
                }

                while (line != null)     //till EOF
                {
                    line = sr.ReadLine();
                    allLines.Add(line);
                }

                sr.Close();

            }
           
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }

            Console.WriteLine("Contents of the file: ");
            for(int i = allLines.Count-1; i >= 0; i--)
            {
                Console.WriteLine(allLines[i]);
                revL += " "+allLines[i];

            }
            revL = revL.TrimStart();

            return revL;
        }
    }
}
