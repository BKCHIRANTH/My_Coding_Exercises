using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeFirstLetter
{
    public class CapitalizeFirstLetters
    {
        public String CapitalizeFirst(String sentence)
        {

            if(sentence == "" || sentence == " ")
            {
                Console.WriteLine("No senetence typed");
                return null;
            }

            if (double.TryParse(sentence, out _))
            {
                Console.WriteLine("Sentence cannot contain only numbers!");
                return null;
            }

            String[] words = new string[sentence.Length];
            words = sentence.Split(' ');

            int leng = words.Length;
            String capitalize = " ";

            for (int i = 0; i < words.Length; i++) 

                {
                    String one = words[i].Substring(0, 1);
                    String later = words[i].Substring(1);
                    capitalize += one.ToUpper() + later + " ";

                }
                Console.WriteLine(capitalize.Trim());
            return capitalize.Trim();
            }
        }
    }
