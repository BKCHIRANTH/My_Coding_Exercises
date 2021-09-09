using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfWordsFromFile
{
   public class Operations
    {
        public String[] readFile(string filepath)
        {

           String[] store = File.ReadAllText(filepath, Encoding.ASCII).Split(new[] { ' ' });

            foreach(var i in store)
            {
                if(i.All(char.IsDigit))
                {
                    return null;
                }
            }

            for (int i = 0; i < store.Length; i++)
            {
                store[i] = store[i].ToLower();
            }

            Array.Sort(store);
            
           String[] wordsReturned = removeDuplicate(store);

            Write(wordsReturned);
            

            return wordsReturned;
        }

        public String[] removeDuplicate(String[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToString().Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid Names entered");
                    String[] turn = { "null" };
                    return turn;
                }
            }
            
            String[] final = new string[names.Length];
            int cnt = 0;
            for (int i = 0; i < names.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (names[i] == names[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    //Console.Write(" "+names[i]);
                    final[cnt++] = names[i];

                }

            }

            return final;
        }

        public bool Write(String[] words)
        {
            try
            {
                Operations op = new Operations();

                System.IO.File.WriteAllLines("D:\\Exercise_Problems\\ListOfWordsFromFile\\Sample_File_ToWrite.txt", words);
                Console.WriteLine("Unique words are written to the file!");
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }

            return true;
        }
    }
}
