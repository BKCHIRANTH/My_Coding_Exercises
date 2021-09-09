using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAndWriteFile
{
    public class ReadAndWrite
    {
        public string Read(string file)
        {
            string line = "";
            string allLines = "";
            try
            {

                StreamReader sr = new StreamReader(file);

                line = sr.ReadLine();    //Reading the first line of text
                allLines += line;

                if (line == null)
                {
                    Console.WriteLine("Nothing to read!");
                    return "emp";
                }

                while (line != null)     //till EOF
                {

                    Console.WriteLine(line);
                    line = sr.ReadLine();
                    allLines += line;
                }

                sr.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }

            finally
            {
                Console.WriteLine("EOF");

            }


            return allLines;
        }

        public bool Write(string file)
        {
            try
            {
                
                StreamWriter sw = new StreamWriter(file);
                
                sw.WriteLine("Sample_Text_To_Be_Written_One!!!");   //1st line
                
                sw.WriteLine("Sample_Text_To_Be_Written_Two!!!");    //2nd line
                
                sw.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }

            finally
            {
                Console.WriteLine("Written everything!");
            }

            return true;
        }
    }
}
