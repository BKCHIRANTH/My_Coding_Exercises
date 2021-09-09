using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveOccurances
{
    public class RemoveChars
    {
        public String removeAllOccurances(String str, char ch)
        {
            if (str == "")
            {
                Console.WriteLine("No string found!");
                return null;
            }

            if (!str.Contains(ch))
            {
                Console.WriteLine("Character to be omitted not found!");
                return null;
            }

            String afterRemoval=null;
            afterRemoval = str.Replace(ch.ToString(), String.Empty);

            if(afterRemoval == null)
            {
                Console.WriteLine("No occurances found!");
                return null;
            }
            
            Console.WriteLine("After omitting the character: {0}",afterRemoval);
            return afterRemoval;
        }
    }
}
