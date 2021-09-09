using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;

namespace ReadTablesInWordFile
{
    class Call
    {
        static void Main(string[] args)
        {
            ReadTables read = new ReadTables();
            read.readWordFile("D:\\Exercise_Problems\\ReadTablesInWordFile\\Sample_File.docx");
            
            Console.ReadLine();

        }
    }
}
