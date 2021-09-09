using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ScoresHistogram
{
   public class Histogram
    {
        public int[] readScores(string file)
        {
            string line = "";
            String score = " ";
           
            
            ArrayList allLines = new ArrayList();

            try
            {

                StreamReader sr = new StreamReader(file);

                line = sr.ReadLine();    //Reading the first line of text
                allLines.Add(line);
                score = score +" "+line;
                

                if (line == null)
                {
                    Console.WriteLine("Nothing to read!");
                    return null;
                }

                while (line != null)     //till EOF
                {

                    
                    line = sr.ReadLine();
                    score = score + " " + line;
                    allLines.Add(line);
                }

                sr.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }

            
            score = score.TrimStart();
            score = score.TrimEnd();

            int[] scoresArr = new int[allLines.Count];

            for (int i = 0; i < allLines.Count; i++)
            {
                
                scoresArr[i] = Convert.ToInt32(allLines[i]);
            }

            
            Counter(scoresArr);

            return scoresArr;
        }


        public int[] Counter(int[] inputNumbers)
        {
            int leng = inputNumbers.Length;
            if (inputNumbers == null)
            {
                return null;
            }

            for (int i = 0; i < leng; i++)
            {
                if (inputNumbers[i] < 0)
                {
                    return null;
                }
            }

            int cnt;
            int b = 0;
            int ind = 0;
            int a;
            int[] result = new int[10];

            for (int i = 0; i < leng; i++)
            {
                if (!int.TryParse(inputNumbers[i].ToString(), out _))    //check if any number is entered
                {
                    return null;
                }
            }

            do
            {
                cnt = 0;
                a = b;

                for (int i = 0; i < leng; i++)     //traversing the input array
                {

                    if (inputNumbers[i] >= a && inputNumbers[i] <= a + 9)
                    {
                        cnt++;
                    }
                }

                Console.WriteLine("No of students scored between {0} and {1} is {2}", a, a + 9, cnt);
                result[ind++] = cnt;  //storing the counts in an array
                b = b + 10;

            } while (a < 90);

            return result;
        }
    }
}
