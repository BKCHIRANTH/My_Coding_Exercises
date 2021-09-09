using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace BatchFileForNotepadCalculator
{
   public class Batch_Class
    {
        public int runNotepad(String app)
        {
            int status;
            String nextApplication = "calc.exe";
            try
            {
                StreamWriter sw = new StreamWriter("test1.bat");
                sw.WriteLine(app);
                sw.Close();

                var note = Process.Start("test1.bat");

                note.WaitForExit();
                status = 0;
                runCalculator(nextApplication);
                
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                status = 1;
            }
            
            return status;
        }

        public int runCalculator(String app2)
        {
            int status;
            try
            {
                if(app2 == " ")
                {
                    return 1;
                }
                StreamWriter sw = new StreamWriter("test.bat");
                sw.WriteLine(app2);
                sw.Close();
                Process.Start("test.bat");
                status = 0;
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                status = 1;
            }
            
            return status;
        }
        
    }
}
