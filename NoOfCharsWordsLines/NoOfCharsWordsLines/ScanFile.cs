using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoOfCharsWordsLines
{
   public class ScanFile
    {
        public int[] ScanFilesForCharsWordsLines(String filepath)
        {
            String line;
            int wordCount = 0;
            int lineCount = 0;
            String[] words = { };
            

            String lineforchar = "";
            String allLines = "";
            try
            {

                StreamReader sr = new StreamReader(filepath);

                lineforchar = sr.ReadLine();    
                allLines += lineforchar;

                if (lineforchar == null)
                {
                    Console.WriteLine("Nothing to read!");
                    return null;
                    
                }

                while (lineforchar != null)     //till EOF
                {
                    lineforchar = sr.ReadLine();
                    allLines += lineforchar;
                }

                sr.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
               
            }
            Char[] totchars = allLines.ToCharArray();


            try
            {
                StreamReader file = new StreamReader(filepath);
                while ((line = file.ReadLine()) != null)
                {

                    words = line.Split(' ');
                    wordCount = wordCount + words.Length;
                    lineCount++;
                }
                file.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;

            }

            Console.WriteLine("\n");
            Console.WriteLine("Number of words present in given file: " + wordCount);
            Console.WriteLine("Number of lines present in given file: " + lineCount);
            Console.WriteLine("Number of characters present in given file: " + totchars.Length);

            int[] totalCounts = new int[] { wordCount, lineCount, totchars.Length };
            

            return totalCounts;
        }
    }
}
