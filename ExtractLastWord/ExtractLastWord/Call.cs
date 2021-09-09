using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractLastWord
{
    class Call
    {
        static void Main(string[] args)
        {
            ExtractLastWords extract = new ExtractLastWords();

            Console.WriteLine("Enter a sentence");
            String sentence = Console.ReadLine();
            Console.WriteLine("\n");

            extract.GetLastWord(sentence);
            Console.ReadLine();
        }
    }
}
