using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFileForNotepadCalculator
{
    class Call
    {
        static void Main(string[] args)
        {
            Batch_Class batch = new Batch_Class();
            String application = "notepad.exe";
            batch.runNotepad(application);

            Console.ReadLine();
        }
    }
}
