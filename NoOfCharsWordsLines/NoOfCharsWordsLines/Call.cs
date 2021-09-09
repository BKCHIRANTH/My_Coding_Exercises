using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfCharsWordsLines
{
    class Call
    {
        static void Main(string[] args)
        {
            ScanFile scan = new ScanFile();
            scan.ScanFilesForCharsWordsLines("D:\\Exercise_Problems\\temp_read.txt");
            Console.ReadLine();
        }
    }
}
