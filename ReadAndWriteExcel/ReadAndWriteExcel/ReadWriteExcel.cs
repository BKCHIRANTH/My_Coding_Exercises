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

using oXL=Microsoft.Office.Interop.Excel.Application;
using oWB = Microsoft.Office.Interop.Excel._Workbook ;
using oSheet =Microsoft.Office.Interop.Excel._Worksheet;
using oRng=Microsoft.Office.Interop.Excel.Range;




namespace ReadAndWriteExcel
{
   public class ReadWriteExcel
    {

        

        public string readExcel(int row, int column)
        {
            if (row <= 0)
            {
                Console.WriteLine("Invalid row number");
                return null;
            }

            if (column <= 0)
            {
                Console.WriteLine("Invalid column number");
                return null;
            }

            try
            {
                Excel.Application oExcel = new Excel.Application();

                
                string filepath = "D:\\Exercise_Problems\\ReadAndWriteExcel\\TempFile1.xls";

                
                Excel.Workbook WB = oExcel.Workbooks.Open(filepath);


                
                string ExcelWorkbookname = WB.Name;

                  
                int worksheetcount = WB.Worksheets.Count;

                Excel.Worksheet wks = (Excel.Worksheet)WB.Worksheets[1];

                

                string firstworksheetname = wks.Name;

                
                string cellvalue = ((Excel.Range)wks.Cells[row, column]).Value;

                Console.WriteLine("Content of Row: {0} and Column: {1} is {2}", row, column, cellvalue);
                return cellvalue;

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }

        public bool writeExcel(int row, int column, String value)
        {
            
            if(row <= 0)
            {
                Console.WriteLine("Invalid row number");
                return false;
            }

            if (column <= 0)
            {
                Console.WriteLine("Invalid column number");
                return false;
            }

            if(value == null)
            {
                return false;
            }
            

            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                Console.WriteLine("Excel is not properly installed!!");
                return false;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[row, column] = value;


            xlWorkBook.SaveAs("D:\\Exercise_Problems\\ReadAndWriteExcel\\TempFile1.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            
            Console.WriteLine("Value inserted!");
            return true;
        }

    }
}
