using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchfileForInstallation
{
   public class RunBatch
    {
        public bool runMyBatchFile(String path)
        {
            if(path == " ")
            {
                return false;
            }
            try
            {
                System.Diagnostics.Process.Start(path);
                return true;
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
