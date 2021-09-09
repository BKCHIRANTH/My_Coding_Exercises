using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOccuranceCharacter
{
   public class MultipleOccurance
    {
        public char[] RepeatedCharacter(String sentence)
        {
            char[] repeatChars = new char[sentence.Length];
            int cnt1 = 0;
            int cnt = 0;
            while (sentence.Length > 0)
            {
                
                cnt = 0;
                

                for(int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == ' ')
                    {
                        continue;
                    }

                    if (sentence[0] == sentence[i])
                    {
                        cnt++;
                    }
                    
                }

                if (cnt > 1)
                {
                    //if any char occurs more than once
                    Console.WriteLine(sentence[0] + " occurred {0} times", cnt);
                    repeatChars[cnt1] = sentence[0];
                    cnt1++;
                    
                }
               
                sentence = sentence.Replace(sentence[0].ToString(), String.Empty); //remove the repeated char
            }

            if (cnt1 == 0)
            {
                Console.WriteLine("No characters repeated");
                return null;
            }

            
            return repeatChars;

        }
    }
}
