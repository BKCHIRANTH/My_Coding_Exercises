using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
//using System.Windows.Documents;
using System.IO;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Runtime.InteropServices.ComTypes;
using DocumentFormat.OpenXml.ExtendedProperties;
using System.Windows;
using System.Collections;
using Microsoft.Office.Interop.Word;
using Document = Microsoft.Office.Interop.Word.Document;
using Application = Microsoft.Office.Interop.Word.Application;

namespace ReadTablesInWordFile
{
   public class ReadTables
    {
        public ArrayList readWordFile(String path)
        {
            
            ArrayList data = new ArrayList();
            try
            {
                Application word = new Application();
                Document doc = new Document();
                if (path == null)
                {
                    return null;
                }

                object fileName = path;

                object missing = System.Type.Missing;
                doc = word.Documents.Open(ref fileName,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing);
                
                for (int i = 0; i < doc.Paragraphs.Count; i++)
                {
                    string temp = doc.Paragraphs[i + 1].Range.Text.Trim();
                    if (temp != string.Empty)
                    {
                        data.Add(temp);

                    }
                        
                }
                ((_Document)doc).Close();
                ((_Application)word).Quit();
            }
            catch(System.NullReferenceException e)
            {
                return null;
            }
            catch (System.Runtime.InteropServices.COMException c)
            {
                return null;
            }

            
            Console.WriteLine("Contents of the word file: ");
            
            foreach (var i in data)
            {
                
                Console.Write("\n" + i );
            }
            
            return data;
        }

    }
}
