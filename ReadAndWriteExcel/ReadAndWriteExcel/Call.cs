using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

using System.Configuration;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.Common;

namespace ReadAndWriteExcel
{
    class Call
    {
        static void Main(string[] args)
        {
            ReadWriteExcel excel = new ReadWriteExcel();
            //FileStream F = new FileStream("D:\\Exercise_Problems\\ReadAndWriteExcel\\TempFile1.xls", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            excel.writeExcel(1, 1, "Hello");
            //excel.writeExcel(2, 1, "Watch");

            //excel.writeExcel(3, 1, "Roar");
            //excel.writeExcel(4, 1, "Grass");
            //excel.writeExcel(5, 1, "India");
            //Console.WriteLine(F.Name);
            Console.WriteLine("\n");
            excel.readExcel(1, 1);
            //excel.readExcel(2, 1);
            //excel.readExcel(3, 1);
            //excel.readExcel(4, 1);
            //excel.readExcel(5, 1);
            //excel.readExcel(6, 1);


            Console.ReadLine();
        }
    }
}
