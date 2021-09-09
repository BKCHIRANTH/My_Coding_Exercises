using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDoubleLetters
{
    public class RemoveDouble
    {
        public String removeDoubledLetters(String str)
        {
            if(str == " ")
            {
                Console.WriteLine("No string entered!");
                return " ";
            }

            if(double.TryParse(str,out _))
            {
                Console.WriteLine("Enter a valid string!");
                return null;
            }
            

            int cnt = 0;
            
            char[] chars = new char[str.Length];

            while (str.Length >= 2)
            {

                if (str[0] == str[1])    //if two letters are similar
                {
                    chars[cnt] = str[0];
                    cnt++;

                    str = str.Remove(0, 1);    
                  
                    str = str.Remove(0, 1);

                }

                else
                {
                    chars[cnt] = str[0];
                    cnt++;
                    str = str.Remove(0, 1);
                   
                }
              
            }

            if (str.Length == 1)
            {
                chars[cnt] = str[0];   //inserting last character if left behind
            }

            int len = 0;
            do
            {
                //Char array contains '\0' chars
                len++;

            } while (chars.Length > len && chars[len] != '\0');

            String finalString = new String(chars, 0, len);
            
            
            Console.Write("\n");
            Console.WriteLine("String after removing double letters: "+finalString);
            
            return finalString;
        }
    }
}
