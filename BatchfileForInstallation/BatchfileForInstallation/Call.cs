using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchfileForInstallation
{
    class Call
    {
        static void Main(string[] args)
        {
            RunBatch run = new RunBatch();
            run.runMyBatchFile("c:\\temp\\TEST.bat");

            Console.ReadLine();
        }
    }
}
