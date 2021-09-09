using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractLastWord
{
    public class ExtractLastWords
    {
        public string GetLastWord(String sentence)
        {
            String last;
            
            last = sentence.Split(' ').Last();
            Console.WriteLine("Last Word: {0}", last);
            return last;

        }
    }
}
