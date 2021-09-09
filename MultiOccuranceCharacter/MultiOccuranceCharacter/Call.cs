using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOccuranceCharacter
{
    class Call
    {
        static void Main(string[] args)
        {
            MultipleOccurance multiple = new MultipleOccurance();
            Console.WriteLine("Enter a sentence");
            String sentence = Console.ReadLine();
            multiple.RepeatedCharacter(sentence);
            Console.ReadLine();
        }
    }
}
