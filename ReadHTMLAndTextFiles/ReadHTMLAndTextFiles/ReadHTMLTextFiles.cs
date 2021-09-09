using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ReadHTMLAndTextFiles
{
   public class ReadHTMLTextFiles
    {
        public ArrayList readTextFile(String dir)
        {
            ArrayList contents = new ArrayList();
           try
            {
                var txtFiles = Directory.EnumerateFiles(dir, "*.txt");
                if(txtFiles == null)
                {
                    return null;
                }

                foreach (string currentFile in txtFiles)
                {
                string line = "";
                
                
                    StreamReader sr = new StreamReader(currentFile);

                    line = sr.ReadLine();
                    contents.Add("Text File Contents:");
                    contents.Add(line);

                    if (line == null)
                    {
                        Console.WriteLine("Nothing to read!");
                        return null;
                    }

                    while (line != null)     
                    {
                        line = sr.ReadLine();
                        contents.Add(line);
                    }
                    
                    contents.Add("End of this text file");
                    
                    sr.Close();

                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }

            foreach (var i in contents)
            {
                Console.WriteLine(i);
            }

            return contents;
        }

        public ArrayList readHTMLFile(String dir)
        {

            var txtFiles = Directory.EnumerateFiles(dir, "*.html");
            ArrayList contents = new ArrayList();

            foreach (string currentFile in txtFiles)
            {
                string line = "";
               
                try
                {

                    StreamReader sr = new StreamReader(currentFile);

                    line = sr.ReadLine();    
                    
                    contents.Add(line);

                    if (line == null)
                    {
                        Console.WriteLine("Nothing to read!");
                        return null;
                    }

                    while (line != null)     
                    {
                        line = sr.ReadLine();
                        
                        contents.Add(line);
                    }

                    sr.Close();

                }

                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                    return null;
                }
                Console.Write("\n");
                Console.WriteLine("Content of HTML files");
                foreach (var i in contents)
                {
                    Console.WriteLine(i);
                }

            }
            return contents;
        }
    }
}
