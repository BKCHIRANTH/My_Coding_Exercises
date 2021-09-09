using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeFirstLetter
{
    class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence");
            String sentence = Console.ReadLine();
            CapitalizeFirstLetters cap = new CapitalizeFirstLetters();
            cap.CapitalizeFirst(sentence);
            Console.ReadLine();
        }
    }
}
